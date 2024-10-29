using System;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace OpenTKHello
{
    public partial class Form1 : Form
    {
        //static double alfa = 0;
        static double alfa1 = 0;
        static double alfa2 = 0;
        static double alfa3 = 0;
        static double alfa4 = 0;
        static double[,] ucgen1 = { { 1f, 1f }, { 2f, 1f }, { 1.5f, 2.0f } };
        static double[,] ucgen2 = { { 0f, 0f }, { 1f, 0f }, { 0.5f, 1.0f } };
        static double[,] ucgen3 = { { -1f, -1f }, { 0f, -1f }, { -0.5f, 0.0f } };
        static double[,] ucgen4 = { { -2f, -2f }, { -1f, -2f }, { -1.5f, -1.0f } };

        public Form1()
        {
            InitializeComponent();
        }

        private void glControl_Load(object sender, EventArgs e)
        {
            glControl.MakeCurrent();
            VertexBuffers.InitVertexBuffers();

            int program = ShaderProgram.InitShadersAndGetProgram();

            int uProjMatrixLoc = GL.GetUniformLocation(program, "uProjMatrix");
            int uViewMatrixLoc = GL.GetUniformLocation(program, "uViewMatrix");

            // Define the view matrix
            Matrix4 viewMatrix = Matrix4.LookAt(
                new Vector3(0f, 0f, 10f),
                new Vector3(0f, 0f, 0f),
                new Vector3(0f, 1f, 0f));
            GL.UniformMatrix4(uViewMatrixLoc, false, ref viewMatrix);

            // Define the project matrix
            Matrix4 projMatrix = Matrix4.CreateOrthographic(50f, 34f, 0.1f, 1000f);
            GL.UniformMatrix4(uProjMatrixLoc, false, ref projMatrix);

            // Our additional codes / bizim eklentilerimiz
            GL.Viewport(0, 0, glControl.Width, glControl.Height);
            GL.ClearColor(0, 0, 0, 1);
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();
            //GL.Rotate(alfa, 0, 0, 1);
            GL.Scale(0.5f, 0.5f, 1);// ekrana daha fazla üçgen çizebilmek için ortamı 0.5 oranında ölçekledim.
            renderTriangles(); // Üçgenleri çizdrme işlemi büyüklüğünden dolayı dış fonksiyona alındı.
            glControl.SwapBuffers();
        }

        private static void renderTriangles()
        {
            ucgendondur(ucgen1, alfa1, 1.5f, 1.5f);
            ucgendondur(ucgen2, alfa2, 0.5f, 0.5f);
            ucgendondur(ucgen3, alfa3, -0.5f, -0.5f);
            ucgendondur(ucgen4, alfa4, -1.5f, -1.5f);

            GL.Begin(PrimitiveType.Triangles); // üçgen 1
            GL.Color3(1f, 0, 0); // R,G,B: 0.0-1.0 veya 0-255
            GL.Vertex2(ucgen1[0, 0], ucgen1[0, 1]);  // Köşe tanımı
            GL.Color3(0, 1f, 0);
            GL.Vertex2(ucgen1[1, 0], ucgen1[1, 1]);
            GL.Color3(0, 0, 1f);
            GL.Vertex2(ucgen1[2, 0], ucgen1[2, 1]);
            GL.End();

            GL.Begin(PrimitiveType.Triangles); // üçgen 2
            GL.Color3(1f, 0, 0); // R,G,B: 0.0-1.0 veya 0-255
            GL.Vertex2(ucgen2[0, 0], ucgen2[0, 1]);
            GL.Color3(0, 1f, 0);
            GL.Vertex2(ucgen2[1, 0], ucgen2[1, 1]);
            GL.Color3(0, 0, 1f);
            GL.Vertex2(ucgen2[2, 0], ucgen2[2, 1]);
            GL.End();

            GL.Begin(PrimitiveType.Triangles); // üçgen 3
            GL.Color3(1f, 0, 0); // R,G,B: 0.0-1.0 veya 0-255
            GL.Vertex2(ucgen3[0, 0], ucgen3[0, 1]);
            GL.Color3(0, 1f, 0);
            GL.Vertex2(ucgen3[1, 0], ucgen3[1, 1]);
            GL.Color3(0, 0, 1f);
            GL.Vertex2(ucgen3[2, 0], ucgen3[2, 1]);
            GL.End();

            GL.Begin(PrimitiveType.Triangles); // üçgen 4
            GL.Color3(1f, 0, 0); // R,G,B: 0.0-1.0 veya 0-255
            GL.Vertex2(ucgen4[0, 0], ucgen4[0, 1]);
            GL.Color3(0, 1f, 0);
            GL.Vertex2(ucgen4[1, 0], ucgen4[1, 1]);
            GL.Color3(0, 0, 1f);
            GL.Vertex2(ucgen4[2, 0], ucgen4[2, 1]);
            GL.End();
        }

        private static void ucgendondur(double[,] ucgen, double alfa, float h, float k)
        {
            if (alfa == 0) return;

            for (int i = 0; i < 3; i++)
            {
                double x = ucgen[i, 0] - h;
                double y = ucgen[i, 1] - k;

                double rotatedX = x * Math.Cos(alfa) - y * Math.Sin(alfa);
                double rotatedY = x * Math.Sin(alfa) + y * Math.Cos(alfa);

                ucgen[i, 0] = rotatedX + h;
                ucgen[i, 1] = rotatedY + k;
            }
        }

        //private static void ucgendondur(double[,] ucgen, double alfa, float h, float k)
        //{
        //    if (alfa == 0) return;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        ucgen[i, 0] = ((ucgen[i, 0] - h) * Math.Cos(alfa) - (ucgen[i, 1] - k) * Math.Sin(alfa) + h);
        //        ucgen[i, 1] = ((ucgen[i, 0] - h) * Math.Sin(alfa) + (ucgen[i, 1] - k) * Math.Cos(alfa) + k);
        //    }
        //}

        private void buttonDondur1_Click(object sender, EventArgs e)
        {
            alfa1 = Math.PI * 0.1d;
            glControl.Refresh();
            alfa1 = 0d;
        }

        private void buttonDondur2_Click(object sender, EventArgs e)
        {
            alfa2 = Math.PI * 0.1d;
            glControl.Refresh();
            alfa2 = 0d;
        }

        private void buttonDondur3_Click(object sender, EventArgs e)
        {
            alfa3 = Math.PI * 0.1d;
            glControl.Refresh();
            alfa3 = 0d;
        }

        private void buttonDondur4_Click(object sender, EventArgs e)
        {
            alfa4 = Math.PI * 0.1d;
            glControl.Refresh();
            alfa4 = 0d;
        }
    }
}
