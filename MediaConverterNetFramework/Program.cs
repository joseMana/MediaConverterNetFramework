using MediaToolkit.Model;
using MediaToolkit.Options;
using MediaToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MediaConverterNetFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cut video down to smaller length
            //var inputFile = new MediaFile { Filename = @"C:\Users\JOSEPH~1\AppData\Local\Temp\sprint planning.mp4" };
            //var outputFile = new MediaFile { Filename = @"C:\Users\JosephManangan\Desktop\sprint planning2.mp4" };

            //using (var engine = new Engine())
            //{
            //    engine.GetMetadata(inputFile);

            //    var options = new ConversionOptions();

            //    // This example will create a 25 second video, starting from the 
            //    // 30th second of the original video.
            //    //// First parameter requests the starting frame to cut the media from.
            //    //// Second parameter requests how long to cut the video.
            //    options.CutMedia(TimeSpan.FromMinutes(12), TimeSpan.FromMinutes(20));

            //    engine.Convert(inputFile, outputFile, options);
            //}

            //Thread.Sleep(4000);

            var inputFile = new MediaFile { Filename = @"C:\Users\JosephManangan\Desktop\sprint planning2.mp4" };
            var outputFile = new MediaFile { Filename = @"C:\Users\JosephManangan\Desktop\sprint planning2.mp3" };

            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
            }
        }


    }
}
