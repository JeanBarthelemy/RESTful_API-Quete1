using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace Restful_API_Quete_1
{
    public class APIqueries
    {
         

        public static string GetUser(int id)
        {
            string EndPoint = "https://jsonplaceholder.typicode.com/users/" + id;

            using (var client = new WebClient())
            {
                return client.DownloadString(EndPoint);
            }
        }

        public static string GetPosts(int id)
        {
            string EndPoint = "https://jsonplaceholder.typicode.com/posts?userId=" + id;

            using (var client = new WebClient())
            {
                return client.DownloadString(EndPoint);
            }
        }

        public static string GetComments(int id)
        {
            string EndPoint = "https://jsonplaceholder.typicode.com/comments?postId=" + id;

            using (var client = new WebClient())
            {
                return client.DownloadString(EndPoint);
            }
        }

        public static string GetAlbums(int id)
        {
            string EndPoint = "https://jsonplaceholder.typicode.com/albums?userId=" + id;

            using (var client = new WebClient())
            {
                return client.DownloadString(EndPoint);
            }
        }

        public static string GetPhotos(int id)
        {
            string EndPoint = "https://jsonplaceholder.typicode.com/photos?albumId=" + id;

            using (var client = new WebClient())
            {
                return client.DownloadString(EndPoint);
            }
        }
    }
}
