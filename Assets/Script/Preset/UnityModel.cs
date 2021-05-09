namespace Coreficent.Preset
{
    using Coreficent.Utility;
    using UnityEngine;

    public class UnityModel : Script
    {
        [SerializeField]
        private SkinnedMeshRenderer button;
        [SerializeField]
        private SkinnedMeshRenderer cheek;
        [SerializeField]
        private SkinnedMeshRenderer hairAccce;
        [SerializeField]
        private SkinnedMeshRenderer hairFront;
        [SerializeField]
        private SkinnedMeshRenderer hairFrontSide;
        [SerializeField]
        private SkinnedMeshRenderer hairBand;
        [SerializeField]
        private SkinnedMeshRenderer leg;
        [SerializeField]
        private SkinnedMeshRenderer shirts;
        [SerializeField]
        private SkinnedMeshRenderer shirtsSode;
        [SerializeField]
        private SkinnedMeshRenderer shirtsSodeBK;
        [SerializeField]
        private SkinnedMeshRenderer skin;
        [SerializeField]
        private SkinnedMeshRenderer tail;
        [SerializeField]
        private SkinnedMeshRenderer tailButtom;
        [SerializeField]
        private SkinnedMeshRenderer uwagi;
        [SerializeField]
        private SkinnedMeshRenderer uwagiBK;
        [SerializeField]
        private SkinnedMeshRenderer mthDef;
        [SerializeField]
        private SkinnedMeshRenderer eyeDef;

        public Material Body
        {
            set
            {
                button.material = value;
                hairAccce.material = value;
                hairBand.material = value;
                leg.material = value;
                shirts.material = value;
                shirtsSode.material = value;
                shirtsSodeBK.material = value;
                uwagi.material = value;
                uwagiBK.material = value;
            }
        }

        public Material EyeL1
        {
            set
            {

            }
        }

        public Material EyeR1
        {
            set
            {

            }
        }

        public Material EyeBase
        {
            set
            {

            }
        }

        public Material EyeLine
        {
            set
            {

            }
        }

        public Material Face
        {
            set
            {
                mthDef.material = value;
                eyeDef.material = value;
            }
        }

        public Material Hair
        {
            set
            {
                hairFront.material = value;
                hairFrontSide.material = value;
                tail.material = value;
                tailButtom.material = value;
            }
        }

        public Material Left
        {
            set
            {

            }
        }

        public Material MatCheek
        {
            set
            {
                cheek.material = value;
            }
        }

        public Material Right
        {
            set
            {

            }
        }

        public Material Skin
        {
            set
            {
                skin.material = value;
            }
        }

    }
}
