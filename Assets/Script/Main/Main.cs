namespace Coreficent.Main
{
    using Coreficent.Preset;
    using Coreficent.Utility;
    using UnityEngine;

    public class Main : Script
    {
        [SerializeField]
        private PresetBase standardShader;

        [SerializeField]
        private PresetBase unityShader;

        [SerializeField]
        private PresetBase animeShader;

        [SerializeField]
        private UnityModel unityModel;

        private bool toggled = false;

        private Main()
        {

        }

        protected void OnGUI()
        {
            GUI.Box(new Rect(Screen.width - 110, 110, 100, 90), "Change Shader");
            if (GUI.Button(new Rect(Screen.width - 100, 140, 80, 20), "Next Shader"))
            {
                Test.Debug("next shader");
            }

            bool toggleState = GUI.Toggle(new Rect(Screen.width - 100, 170, 80, 20), toggled, "toggled");

            if (toggleState != toggled)
            {
                toggled = toggleState;
                Test.Debug("toggle", toggled);
            }
        }

        protected void Update()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                unityModel.Body = unityShader.Body;
                unityModel.Hair = unityShader.Hair;
                unityModel.Skin = unityShader.Skin;
                unityModel.Face = unityShader.Face;
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                unityModel.Body = standardShader.Body;
                unityModel.Hair = standardShader.Hair;
                unityModel.Skin = standardShader.Skin;
                unityModel.Face = standardShader.Face;
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                unityModel.Body = animeShader.Body;
                unityModel.Hair = animeShader.Hair;
                unityModel.Skin = animeShader.Skin;
                unityModel.Face = animeShader.Face;
            }
        }
    }
}
