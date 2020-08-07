using Hiq.Dxs.SystemSalesman.Application.Models.BaseVM;
using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hiq.Dxs.SystemSalesman.Application.Models
{
    public class ClientVM : BasicVM
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name required")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country required")]
        public string Country { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date required")]
        public DateTime BeginDate { get; set; }


        public IClient ToClient()
        {
            return new Client(FullName, Country, BeginDate);
        }

        public IClient ToClient(IClient client)
        {
            client.FullName = FullName;
            client.Country = Country;
            client.BeginDate = BeginDate;

            return client;
        }

        public static ClientVM Parse(IClient vm)
        {
            return new ClientVM()
            {
                Id = vm.Id,
                FullName = vm.FullName,
                Country = vm.Country,
                BeginDate = vm.BeginDate
            };
        }

        public bool CompareToModel(IClient model)
        {
            return FullName == model.FullName &&
                    Country == model.Country &&
                    BeginDate == model.BeginDate;
        }
    }
}
