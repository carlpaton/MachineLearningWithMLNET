using Microsoft.ML.Data;
using System;
using System.Collections.Generic;

namespace ImageClassificationTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<ImageData> allImages = LoadImagesFromDirectory(folder: fullImagesetFolderPath,
            //                                                            useFolderNameasLabel: true);
        }
    }

    public class ImageData
    {
        [LoadColumn(0)]
        public string ImagePath;

        [LoadColumn(1)]
        public string Label;
    }
}
