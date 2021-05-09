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
        private UnityModel unityModel;


        private Main()
        {

        }

        protected override void Start()
        {
            unityModel.Body = standardShader.Body;
            unityModel.Hair = standardShader.Hair;
            //unityModel.MatCheek = standardShader.MatCheek;
            unityModel.Skin = standardShader.Skin;
            unityModel.Face = standardShader.Face;

            base.Start();
        }
    }
}
