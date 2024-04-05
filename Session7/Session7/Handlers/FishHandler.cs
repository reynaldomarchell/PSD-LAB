using Session7.Factories;
using Session7.Models;
using Session7.Modules;
using Session7.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session7.Handlers
{
    public class FishHandler
    {
        public static Response<List<Fish>> GetAllFish()
        {
            List<Fish> fishes = FishRepository.GetAllFish();

            return new Response<List<Fish>>
            {
                Success = true,
                Message = "success",
                payload = fishes
            };
        }

        public static Response<Fish> GetFish(String id)
        {
            Fish fish = FishRepository.GetFish(id);

            if (fish == null)
            {
                return new Response<Fish>
                {
                    Success = false,
                    Message = "failed",
                    payload = null
                };
            }

            return new Response<Fish>
            {
                Success = true,
                Message = "success",
                payload = fish
            };
        }

        public static String GenerateId()
        {
            Fish fish = FishRepository.GetLastFish();

            if (fish == null)
            {
                return "FI001";
            }

            String id = fish.Id;
            int lastNum = Convert.ToInt32(id.Substring(2));
            lastNum++;
            String newId = String.Format("FI{0:000}", lastNum);
            return newId;
        }

        public static Response<Fish> UpdateFish(String id, String name, int price)
        {
            Fish fish = FishFactory.Create(id, name, price);
            Fish updatedFish = FishRepository.UpdateFish(fish);
            if(updatedFish == null)
            {
                return new Response<Fish>
                {
                    Success = false,
                    Message = "failed",
                    payload = null
                };
            }

            return new Response<Fish>
            {
                Success = true,
                Message = "success",
                payload = fish
                // payload = updatedFish
            };
        }

        public static Response<Fish> Create(String name, int price)
        {
            Fish fish = FishFactory.Create(GenerateId(), name, price);
            FishRepository.CreateFish(fish);

            return new Response<Fish>
            {
                Success = true,
                Message = "success",
                payload = fish
            };
        }

        public static Response<Fish> DeleteFish(String id)
        {
            Boolean isDeleted = FishRepository.DeleteFish(id);

            if (isDeleted)
            {
                return new Response<Fish>
                {
                    Success = true,
                    Message = "success",
                    payload = null
                };
            }

            return new Response<Fish>
            {
                Success = false,
                Message = "failed",
                payload = null
            };
        }
    }
}