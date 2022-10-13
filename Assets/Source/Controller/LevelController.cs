using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Newtonsoft.Json;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class LevelController : ControllerBaseModel
{
    public LevelModel ActiveLevel;
    [SerializeField] List<LevelModel> levels;

    public override void Initialize()
    {
        base.Initialize();
        loadLevel();
    }

    private void loadLevel()
    {
        ActiveLevel = levels[PlayerDataModel.Data.LevelIndex];
    }

    public void NextLevel()
    {
        PlayerDataModel.Data.Level++;
        PlayerDataModel.Data.LevelIndex = PlayerDataModel.Data.LevelIndex + 1 < levels.Count ? PlayerDataModel.Data.LevelIndex + 1 : 0;
        PlayerDataModel.Data.Save();
    }
}
