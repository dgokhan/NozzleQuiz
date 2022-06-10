using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization;

namespace NozzleQuiz.Integrations.NozzleSoft.Serializer
{
    public class NewtonsoftJsonSerializer : IRestSerializer
    {
        public T Deserialize<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public string ContentType { get; set; } = RestSharp.Serialization.ContentType.Json;

        public string[] SupportedContentTypes { get; } = RestSharp.Serialization.ContentType.JsonAccept;

        public DataFormat DataFormat { get; } = DataFormat.Json;

        public string Serialize(Parameter parameter) => Serialize(parameter.Value);
    }
}
