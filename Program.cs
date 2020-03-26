using System;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;

namespace Restful_API_Quete_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select whose user you would like to see the infos (enter an ID number).");
            int idNumber = Convert.ToInt32(Console.ReadLine());
            
            string resultUser = APIqueries.GetUser(idNumber);
            string resultPosts = APIqueries.GetPosts(idNumber);
            string resultComments = APIqueries.GetComments(idNumber);
            string resultAlbums = APIqueries.GetAlbums(idNumber);
            string resultPhotos = APIqueries.GetPhotos(idNumber);

            User user = JsonConvert.DeserializeObject<User>(resultUser);

            List<Post> postsList = JsonConvert.DeserializeObject<List<Post>>(resultPosts);

            List<Comment> commentsList = JsonConvert.DeserializeObject<List<Comment>>(resultComments);

            List<Album> albumsList = JsonConvert.DeserializeObject<List<Album>>(resultAlbums);

            List<Photo> photosList = JsonConvert.DeserializeObject<List<Photo>>(resultPhotos);


            Console.WriteLine("Posts of "+ user.name + " : \n");
            int i = 1;

            foreach (Post p in postsList)
            {
                Console.WriteLine("Post " + i + " :" + "\n" + p.title + "\n" + "\n" + p.body + "\n");
                Console.WriteLine();
                i++;
                int j = 1;

                foreach (Comment c in commentsList)
                {
                    Console.WriteLine("Comment " + j + " : " + "\n" + c.body);
                    Console.WriteLine();
                    j++;
                }

                Console.WriteLine();
            }

            i = 1;
            foreach (Album a in albumsList)
            {
                Console.WriteLine("Album " + i + " :" + "\n" + a.title + "\n");
                Console.WriteLine();
                i++;
                int k = 1;
                foreach (Photo ph in photosList)
                {
                    Console.WriteLine("Photo " + k + " : " + "\n" + ph.title + "\n" + ph.url + "\n");
                    Console.WriteLine();
                    k++;
                }

                Console.WriteLine();
            }
        }
    }
}       
    

