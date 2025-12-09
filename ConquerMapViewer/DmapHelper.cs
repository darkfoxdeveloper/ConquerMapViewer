using System.Diagnostics;
using System.Text;

namespace ConquerMapViewer
{
    public static class DmapHelper
    {
        public class Result
        {
            public int ExitCode { get; set; }
            public string StdOut { get; set; } = "";
            public string StdErr { get; set; } = "";
        }

        /// <summary>
        /// Execute in shell: Tiled2Dmap.CLI.exe stitch-dmap --output ... --client ... --dmap ...
        /// </summary>
        public static Result RunStitchDmap(
            string cliExePath,
            string outputDir,
            string clientDir,
            string dmapPath,
            int timeoutMs = 60000)
        {
            var psi = new ProcessStartInfo
            {
                FileName = cliExePath,
                Arguments =
                    $"stitch-dmap --output \"{outputDir}\" --client \"{clientDir}\" --dmap \"{dmapPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var stdoutSb = new StringBuilder();
            var stderrSb = new StringBuilder();

            using (var proc = new Process())
            {
                proc.StartInfo = psi;

                proc.OutputDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                        stdoutSb.AppendLine(e.Data);
                };

                proc.ErrorDataReceived += (s, e) =>
                {
                    if (e.Data != null)
                        stderrSb.AppendLine(e.Data);
                };

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();

                if (!proc.WaitForExit(timeoutMs))
                {
                    try { proc.Kill(); } catch { /* ignorar */ }
                    throw new Exception($"Timeout ejecutando Tiled2Dmap ({timeoutMs / 1000}s).");
                }

                proc.WaitForExit();

                return new Result
                {
                    ExitCode = proc.ExitCode,
                    StdOut = stdoutSb.ToString(),
                    StdErr = stderrSb.ToString()
                };
            }
        }
    }
}
