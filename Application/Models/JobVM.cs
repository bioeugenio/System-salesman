using Hiq.Dxs.SystemSalesman.Application.Models.BaseVM;
using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;


namespace Hiq.Dxs.SystemSalesman.Application.Models
{
    public class JobVM : BasicVM
    {
        [Required(ErrorMessage = "Address required")]
        public string Address { get; set; }

        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date required")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Budget required")]
        [RegularExpression("^([0-9]+,[0-9]+)$", ErrorMessage = "Format must be XXX,XX")]
        public string Budget { get; set; }

        [Required(ErrorMessage = "Status required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Rating required")]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Display(Name = "Rated")]
        public bool Rated { get; set; }

        
        [Display(Name = "Client")]
        [Required(ErrorMessage = "Client required")]
        public Guid ClientId { get; set; }

        public IJob ToJob()
        {
            return new Job(Address, StartDate, EndDate, Double.Parse(Budget), Status, Rating, Rated, ClientId);
        }

        public IJob ToJob(IJob job)
        {
            job.Address = Address;
            job.StartDate = StartDate;
            job.EndDate = EndDate;
            job.Budget = Double.Parse(Budget);
            job.Status = Status;
            job.Rating = Rating;
            job.Rated = Rated;           
            job.ClientId = ClientId;

            return job;
        }

        public static JobVM Parse(IJob vm)
        {
            return new JobVM()
            {
                Id = vm.Id,
                Address = vm.Address,
                StartDate = vm.StartDate,
                EndDate = vm.EndDate,
                Budget = vm.Budget.ToString(),
                Status = vm.Status,
                Rating = vm.Rating,
                Rated = vm.Rated,              
                ClientId = vm.ClientId
            };
        }

        public bool CompareToModel(IJob model)
        {
            return Address == model.Address &&
                    StartDate == model.StartDate &&
                    EndDate == model.EndDate &&
                    Budget == model.Budget.ToString() &&
                    Status == model.Status &&
                    Rating == model.Rating &&
                    Rated == model.Rated &&                    
                    ClientId == model.ClientId;
        }
    }
}
