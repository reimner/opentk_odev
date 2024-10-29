using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;

namespace OpenTKHello
{
    class VertexBuffers
    {
        public static void InitVertexBuffers()
        {
            float[] vertices = new float[]
            {
                0f, 0f,
                1f, 0f,
                0f, 1.452f,
                1f, 1.452f
            };

            // Create a buffer for our vertex positions
            int vertexBuffer;
            GL.GenBuffers(1, out vertexBuffer);

            // Set the vertex buffer as active buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, vertexBuffer);

            // Get an array size in bytes
            int sizeInBytes = vertices.Length * sizeof(float);
            // Send the vertex array to a video card memory
            GL.BufferData(BufferTarget.ArrayBuffer, sizeInBytes, vertices, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(0);

            float[] textureCoords = new float[]
            {
                0f, 0f,
                1f, 0f,
                0f, 1f,
                1f, 1f
            };

            // Create a buffer for our vertex positions
            int textureBuffer;
            GL.GenBuffers(1, out textureBuffer);

            // Set the vertex buffer as active buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, textureBuffer);

            // Get an array size in bytes
            sizeInBytes = textureCoords.Length * sizeof(float);
            // Send the vertex array to a video card memory
            GL.BufferData(BufferTarget.ArrayBuffer, sizeInBytes, textureCoords, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, 0, 0);
            GL.EnableVertexAttribArray(1);
        }
    }
}
