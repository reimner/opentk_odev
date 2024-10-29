using System;
using OpenTK.Graphics.OpenGL;

namespace OpenTKHello
{
    class ShaderProgram
    {
        public static int InitShadersAndGetProgram()
        {
            string vertexShaderSource =
                "#version 140\n" +
                "in vec2 aPosition;" +
                "in vec2 aTexCoord;" +
                "out vec2 vTexCoord;" +
                "uniform mat4 uProjMatrix;" +
                "uniform mat4 uViewMatrix;" +
                "uniform mat4 uModelMatrix;" +
                "void main()" +
                "{" +
                "    gl_Position = uProjMatrix * uViewMatrix * uModelMatrix * vec4(aPosition, 1.0, 1.0);" +
                "    vTexCoord = aTexCoord;" +
                "}";

            string fragmentShaderSource =
                "#version 140\n" +
                "out vec4 fragColor;" +
                "in vec2 vTexCoord;" +
                "uniform sampler2D uSampler;" +
                "void main()" +
                "{" +
                "    fragColor = texture(uSampler, vec2(vTexCoord.s, 1 - vTexCoord.t));" +
                "}";

            // Vertex Shader
            int vShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vShader, vertexShaderSource);
            GL.CompileShader(vShader);
            // Check compilation
            string vShaderInfo = GL.GetShaderInfoLog(vShader);
            if (!vShaderInfo.StartsWith("No errors"))
            {
                Console.WriteLine(vShaderInfo);
                return -1;
            }

            // Fragment Shader
            int fShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(fShader, fragmentShaderSource);
            GL.CompileShader(fShader);
            string fShaderInfo = GL.GetShaderInfoLog(fShader);
            if (!fShaderInfo.StartsWith("No errors"))
            {
                Console.WriteLine(fShaderInfo);
                return -1;
            }

            int program = GL.CreateProgram();
            GL.AttachShader(program, vShader);
            GL.AttachShader(program, fShader);
            GL.LinkProgram(program);
            GL.UseProgram(program);

            return program;
        }
    }
}
