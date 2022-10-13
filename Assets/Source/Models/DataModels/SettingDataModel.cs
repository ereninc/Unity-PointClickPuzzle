using System;

[Serializable]
public class SettingDataModel : DataModel
{
    public static SettingDataModel Data;
    public bool Vibration;
    public bool Sound;

    public SettingDataModel Load()
    {
        if (Data == null)
        {
            Data = this;
            object data = LoadData();

            if (data != null)
            {
                Data = (SettingDataModel)data;
            }
        }

        return Data;
    }

    public void Save()
    {
        Save(Data);
    }
}
