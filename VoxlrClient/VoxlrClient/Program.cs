/*    
 * Copyright (C) 2011, H�seyin Uslu
 *  
 */

namespace VolumetricStudios.VoxlrClient
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (var game = new VolumetricStudios.VoxlrClient.VoxlrClient())
            {
                game.Run();
            }
        }
    }
}

