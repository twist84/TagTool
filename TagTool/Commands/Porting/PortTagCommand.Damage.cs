﻿using System;
using System.IO;
using TagTool.Cache;
using TagTool.Damage;
using TagTool.Tags.Definitions;

namespace TagTool.Commands.Porting
{
    public partial class PortTagCommand
    {
        public DamageEffect ConvertDamageEffect(DamageEffect damageEffect)
        {
            if (BlamCache.Version == CacheVersion.HaloReach)
            {
                damageEffect.Flags = damageEffect.FlagsReach.ConvertLexical<DamageEffect.DamageFlags>();

                if(damageEffect.CustomResponseLabels.Count > 0)
                    damageEffect.CustomResponseLabel = damageEffect.CustomResponseLabels[0].CustomLabel;
            }

            return damageEffect;
        }

        public DamageResponseDefinition ConvertDamageResponseDefinition(Stream blamCacheStream, DamageResponseDefinition damageResponse)
        {
            if (BlamCache.Version == CacheVersion.HaloReach)
            {
                foreach(var responseClass in damageResponse.Classes)
                {
                    responseClass.DirectionalFlash.Size = responseClass.DirectionalFlash.CenterSize;

                    if(responseClass.RumbleReference != null)
                    {
                        var rumble = BlamCache.Deserialize<Rumble>(blamCacheStream, responseClass.RumbleReference);
                        responseClass.Rumble = rumble;
                    }

                    if (responseClass.CameraShakeReachReference != null)
                    {
                        var cameraShake = BlamCache.Deserialize<CameraShake>(blamCacheStream, responseClass.CameraShakeReachReference);
                        responseClass.CameraShake = ConvertCameraShake(cameraShake);
                    }
                }
            }

            return damageResponse;
        }

        public CameraShake ConvertCameraShake(CameraShake cameraShake)
        {
            // TODO
            return cameraShake;
        }

        public DamageReportingType ConvertDamageReportingType(DamageReportingType damageReportingType)
        {
            string value = null;

            switch (BlamCache.Version)
            {
                case CacheVersion.Halo2Vista:
                case CacheVersion.Halo2Xbox:
                    value = damageReportingType.Halo2Retail.ToString();
                    break;

                case CacheVersion.Halo3ODST:
                    if (damageReportingType.Halo3ODST == DamageReportingType.Halo3ODSTValue.ElephantTurret)
                        value = DamageReportingType.HaloOnlineValue.GuardiansUnknown.ToString();
                    else
                        value = damageReportingType.Halo3ODST.ToString();
                    break;

                case CacheVersion.Halo3Retail:
                    if (damageReportingType.Halo3Retail == DamageReportingType.Halo3RetailValue.ElephantTurret)
                        value = DamageReportingType.HaloOnlineValue.GuardiansUnknown.ToString();
                    else
                        value = damageReportingType.Halo3Retail.ToString();
                    break;
                case CacheVersion.HaloReach:
                    value = damageReportingType.HaloReach.ToString();
                    break;
            }

            if (value == null || !Enum.TryParse(value, out damageReportingType.HaloOnline))
                throw new NotSupportedException(value ?? CacheContext.Version.ToString());

            return damageReportingType;
        }
    }
}