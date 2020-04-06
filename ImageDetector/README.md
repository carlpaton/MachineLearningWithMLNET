Having a hoon at machine learning with ML.NET, this is a `.net core 2.2` project. The Platform target needs to be `x64` with nugget references:

```
Microsoft.ML                        1.4.0
Microsoft.ML.ImageAnalytics         1.4.0
Microsoft.ML.TensorFlow             1.4.0
Microsoft.ML.TensorFlow.Redist      0.14.0
SciSharp.TensorFlow.Redist          2.1.0
```

Initial code is based on this great [medium.com article by Mark Farragher](https://medium.com/machinelearningadvantage/detect-any-object-in-an-image-using-c-and-ml-net-machine-learning-50e606b821a3) with the inception model and images from [dotnet/machinelearning-samples](https://github.com/dotnet/machinelearning-samples)

### References 

* https://medium.com/machinelearningadvantage/detect-any-object-in-an-image-using-c-and-ml-net-machine-learning-50e606b821a3
* https://github.com/dotnet/machinelearning-samples/tree/master/samples/csharp/getting-started/DeepLearning_ImageClassification_TensorFlow/ImageClassification/assets/inputs/inception
* https://github.com/dotnet/machinelearning-samples/tree/master/samples/csharp/getting-started/DeepLearning_ImageClassification_TensorFlow/ImageClassification/assets/inputs/images