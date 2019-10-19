using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace WebApiDemo
{
    public class JsonContentNegotiator : IContentNegotiator
    {
        private readonly JsonMediaTypeFormatter _Formatter;

        public JsonContentNegotiator(JsonMediaTypeFormatter formatter) => _Formatter = formatter;

        public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        => new ContentNegotiationResult(_Formatter, new MediaTypeHeaderValue("application/json"));

    }
}