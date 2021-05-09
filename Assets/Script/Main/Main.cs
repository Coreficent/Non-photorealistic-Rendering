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
        private SkinnedMeshRenderer body;


        private Main()
        {

        }

        protected override void Start()
        {
            body.material = standardShader.Body;

            base.Start();
        }
    }
}
