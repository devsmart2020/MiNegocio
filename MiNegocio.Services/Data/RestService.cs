﻿using MiNegocio.Services.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MiNegocio.Services.Data
{
    public class RestService<T> : IRestService<T>
    {
        #region Private Members Variables
        private HttpClient _httpClient;    
        #endregion

        #region Constructor
        public RestService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(string.Format(GetConnectionStringByName()))
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(Resources.RequestHeaders));
         
        }
        #endregion

        #region Public Methods
        public async Task<bool> Delete(string id)
        {
            Uri uri = new Uri(_httpClient.BaseAddress, id);
            try
            {
                using (HttpResponseMessage httpResponse = await _httpClient.DeleteAsync(uri))
                {
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorRestService = $"{httpResponse.ReasonPhrase} Código: {httpResponse.StatusCode}";
                        return false;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(@"\tError {0}", ex.Message);
                ErrorRestService = ex.Message;
                return false;
            }
        }

        public async Task<T> GetById(string controllerName, T entity)
        {
            Uri uri = new Uri(string.Format($"{_httpClient.BaseAddress}{controllerName}", entity));
            try
            {
                string json = JsonConvert.SerializeObject(entity);
                StringContent content = new StringContent(json, Encoding.UTF8, Resources.RequestHeaders);
                using (HttpResponseMessage httpResponse = await _httpClient.PostAsync(uri, content))
                {
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        var query = await httpResponse.Content.ReadAsStringAsync();
                        var model = JsonConvert.DeserializeObject<T>(query);
                        return model;
                    }
                    else
                    {
                        ErrorRestService = $"{httpResponse.ReasonPhrase} Código: {httpResponse.StatusCode}";
                        return default;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(@"\tError {0}", ex.Message);
                ErrorRestService = ex.Message;
                return default;
            }
        }

        public Task<IEnumerable<T>> GetListEntity(string controllerName, T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetTs(string controllerName)
        {
            Uri uri = new Uri(string.Format($"{_httpClient.BaseAddress}{controllerName}"));
            try
            {
                using (HttpResponseMessage httpResponse = await _httpClient.GetAsync(uri))
                {
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<IEnumerable<T>>(content);
                    }
                    else
                    {
                        ErrorRestService = $"{httpResponse.ReasonPhrase} Código: {httpResponse.StatusCode}";
                        return default;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(@"\tError {0}", ex.Message);
                ErrorRestService = ex.Message;
                return default;
            }
        }

        public async Task<T> Login(string controllerName, T entity)
        {
            Uri uri = new Uri(string.Format($"{_httpClient.BaseAddress}{controllerName}", entity));
            try
            {
                string json = JsonConvert.SerializeObject(entity);
                StringContent content = new StringContent(json, Encoding.UTF8, Resources.RequestHeaders);
                using (HttpResponseMessage httpResponse = await _httpClient.PostAsync(uri, content))
                {
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        var query = await httpResponse.Content.ReadAsStringAsync();
                        var model = JsonConvert.DeserializeObject<T>(query);
                        return model;
                    }
                    else
                    {
                        ErrorRestService = $"{httpResponse.ReasonPhrase} Código: {httpResponse.StatusCode}";
                        return default;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(@"\tError {0}", ex.Message);
                ErrorRestService = ex.Message;
                return default;
            }
        }

        public async Task<bool> Post(T entity, bool isNewItem)
        {
            Uri uri = new Uri($"{_httpClient.BaseAddress}");
            try
            {
                string json = JsonConvert.SerializeObject(entity);
                StringContent content = new StringContent(json, Encoding.UTF8, Resources.RequestHeaders);
                if (isNewItem)
                {
                    using (HttpResponseMessage httpResponse = await _httpClient.PostAsync(uri, content))
                    {
                        if (httpResponse.IsSuccessStatusCode)
                        {
                            return true;
                        }
                        else
                        {
                            ErrorRestService = $"{httpResponse.ReasonPhrase} Código: {httpResponse.StatusCode}";
                            return false;
                        }
                    }

                }
                else
                {
                    using (HttpResponseMessage httpResponse = await _httpClient.PutAsync(uri, content))
                    {
                        if (httpResponse.IsSuccessStatusCode)
                        {
                            return true;
                        }
                        else
                        {
                            ErrorRestService = $"{httpResponse.ReasonPhrase} Código: {httpResponse.StatusCode}";
                            return false;
                        }
                    }
                }
                
            }
            catch (HttpRequestException ex)
            {
                Debug.WriteLine(@"\tError {0}", ex.Message);
                ErrorRestService = ex.Message;
                return false;
            }            
        }
        #endregion

        #region Static Methods
        static string GetConnectionStringByName()
        {
            string returnValue = string.Empty;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[Resources.ConnectionConfig];
            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }
        public static void InitializeClient()
        {

        }
        public static string ErrorRestService { get; set; }
        #endregion
    }
}