namespace Coreficent.Preset
{
    using Coreficent.Utility;
    using UnityEngine;

    /*
     * shader and material preset holder
     */

    public class PresetBase : Script
    {
        public Material Body;
        public Material EyeL1;
        public Material EyeR1;
        public Material EyeBase;
        public Material EyeLine;
        public Material Face;
        public Material Hair;
        public Material Left;
        public Material MatCheek;
        public Material Right;
        public Material Skin;
        public Material Floor;

        public float OutlineWidth
        {
            set
            {
                Body.SetFloat("_OutlineThickness", value);
                EyeL1.SetFloat("_OutlineThickness", value);
                EyeR1.SetFloat("_OutlineThickness", value);
                EyeBase.SetFloat("_OutlineThickness", value);
                EyeLine.SetFloat("_OutlineThickness", value);
                Face.SetFloat("_OutlineThickness", value);
                Hair.SetFloat("_OutlineThickness", value);
                Left.SetFloat("_OutlineThickness", value);
                MatCheek.SetFloat("_OutlineThickness", value);
                Right.SetFloat("_OutlineThickness", value);
                Skin.SetFloat("_OutlineThickness", value);
                Floor.SetFloat("_OutlineThickness", value);
            }
        }
    }
}
