using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace OpenTKHello
{
    class Textures
    {
        public static bool LoadTexture(string textureName, out int textureID)
        {
            textureID = GL.GenTexture();

            // Create the image object
            Bitmap image = null;
            try
            {
                image = new Bitmap(textureName);
            }
            catch (Exception e)
            {
                Console.WriteLine("File \"Textures.cs\". Cannot find the texture: " + textureName +", Exception: " + e.Message);
                return false;
            }

            // Bind the texture object to the target
            GL.BindTexture(TextureTarget.Texture2D, textureID);

            BitmapData data = image.LockBits(new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            // Set the texture image
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, image.Width, image.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

            image.UnlockBits(data);

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);

            GL.BindTexture(TextureTarget.Texture2D, 0);

            return true;
        }

        public static void ActiveTexture(int textureID)
        {
            GL.BindTexture(TextureTarget.Texture2D, textureID);

            // To prevent texture wrappings
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)All.ClampToEdge);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)All.ClampToEdge);

            // Handles how magnification and minimization filters will work
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.LinearMipmapLinear);

            // Enable texture unit0
            GL.ActiveTexture(TextureUnit.Texture0);
        }
    }
}
