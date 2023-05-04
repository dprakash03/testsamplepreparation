using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;

namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                singletonlazy singletonlazyobj = singletonlazy.GetSingletonlazy;
                singletonlazyobj.username = "hello prakash";

                singletonlazy singletonlazyobj1 = singletonlazy.GetSingletonlazy;
                Console.WriteLine(singletonlazyobj1.username);
                //var jwt = "eyJraWQiOiJ6YmVIcGdsZUhxRGU3Y21ob3RaREhrTFFxbmdkMXphUl9kUE5CclBjX0hVIiwiYWxnIjoiUlMyNTYifQ.eyJ2ZXIiOjEsImp0aSI6IkFULnlkbkJKUVNfeWIxT2N3b2M3SWpqOEdGZW5DbnVlOHhaZnYySmhsUVhUcTgiLCJpc3MiOiJodHRwczovL2Rldi0yNzUyOTU1Ny5va3RhLmNvbSIsImF1ZCI6Imh0dHBzOi8vZGV2LTI3NTI5NTU3Lm9rdGEuY29tIiwic3ViIjoicHJha2FzaC5nb29uZGxhQGNvbXB1Z2Fpbi5jb20iLCJpYXQiOjE2MzE2MDA2MTgsImV4cCI6MTYzMTYwNDIxOCwiY2lkIjoiMG9hMXMweW5kalBqcG5BWEc1ZDciLCJ1aWQiOiIwMHUxczBxZzA4d0JKQ0l5MzVkNyIsInNjcCI6WyJvcGVuaWQiLCJwcm9maWxlIiwiZW1haWwiXX0.d_C-3l52P5mEEhNCHlMQWnIt0WYIJoccSCu5zszb8CguJFjLI8_ST2oYo49LQAIFdNSKbBkwCzt5keCxe03K9HkF5ISFigyIoYM7ncejz4U6vhkibzY9xfSqGjXoLXAOb8_g7eMh-RBqPQmzirVC9osyCy1fxaXfgqOOt8z-Y_gscwsqAKZyJ4O3FyFMslns0LR_lmYYvgSRrqr6Y_dpMsqs0vlw62qck9f5xvAOL6--XYoX3VuMxSOucUpXyaIerzTe18kz2YMPQnCeXS-6e2O626YrTQ9jd4A67amYSdrxU3J8_kF7srzaOrByfmG6abq6CaDkUF2Ig8xXA2TDPA";
                //var handler = new JwtSecurityTokenHandler();
                //var token = handler.ReadJwtToken(jwt);
                

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        public static int thirdlargestnum(int[] numbers,int[] num)
        {
            return 1;
        }
        public static int thirdlargestnum(int[] numbers)
        {
            int firstlarge = int.MinValue;
            int secondlarge = int.MinValue;
            int thirdlarge = int.MinValue;
            foreach (int num in numbers)
            {
                if(num>firstlarge)
                {
                    thirdlarge = secondlarge;
                    secondlarge = firstlarge;
                    firstlarge = num;

                }
                else if(num > secondlarge)
                {
                    thirdlarge = secondlarge;
                    secondlarge = num;
                }
                else if (num > thirdlarge)
                {

                    thirdlarge = num;
                }
            }
            return thirdlarge;
        }


    }
}

