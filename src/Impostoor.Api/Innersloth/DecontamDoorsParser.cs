namespace Impostor.Api.Innersloth
{
    public static class DecontamDoorsParser
    {
        public static DecontamDoors Parse(byte mapId, SystemTypes systemType, byte amount)
        {
            if (amount < 1 || amount > 4)
            {
                return DecontamDoors.None;
            }

            if (mapId == 0 || mapId > 2)
            {
                return DecontamDoors.None;
            }

            byte offset = 0;

            if (mapId == 1 && systemType != SystemTypes.Decontamination)
            {
                return DecontamDoors.None;
            }

            if (mapId == 2)
            {
                if (systemType == SystemTypes.TopDecontaminationPolus)
                {
                    offset += 4;
                }
                else if (systemType == SystemTypes.Decontamination)
                {
                    offset += 8;
                }
                else
                {
                    return DecontamDoors.None;
                }
            }

            return (DecontamDoors)(amount + offset);
        }
    }
}
