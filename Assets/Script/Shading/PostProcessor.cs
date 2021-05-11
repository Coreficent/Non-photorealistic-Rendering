namespace Coreficent.Shading
{
    using Coreficent.Utility;
    using UnityEngine;

    /*
     * sobel filter post processing toggle
     */

    public class PostProcessor : Script
    {
        [SerializeField] private Material material;

        private bool on = false;

        protected void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            if (on)
            {
                Graphics.Blit(source, destination, material);
            }
            else
            {
                Graphics.Blit(source, destination);
            }
        }

        public bool On
        {
            set
            {
                on = value;
            }
        }
    }
}
