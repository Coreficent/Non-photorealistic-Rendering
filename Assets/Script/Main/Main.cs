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

        private Main()
        {

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
