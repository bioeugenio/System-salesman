using Hiq.Dxs.SystemSalesman.Application.Models.BaseVM;
using Hiq.Dxs.SystemSalesman.DataLayer;
using Hiq.Dxs.SystemSalesman.DataLayer.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hiq.Dxs.SystemSalesman.Application.Models
{
    public class ProposalVM : BasicVM
    {
        [Required(ErrorMessage = "Sender required")]
        public string Sender { get; set; }

        [Required(ErrorMessage = "Message required")]
        public string Message { get; set; }

        [Display(Name = "Job")]
        [Required(ErrorMessage = "Job required")]
        public Guid JobId { get; set; }

        public IProposal ToProposal()
        {
            return new Proposal(Sender, Message, JobId);
        }

        public IProposal ToProposal(IProposal proposal)
        {
            proposal.Sender = Sender;
            proposal.Message = Message;
            proposal.JobId = JobId;

            return proposal;
        }

        public static ProposalVM Parse(IProposal vm)
        {
            return new ProposalVM()
            {
                Id = vm.Id,
                Sender = vm.Sender,
                Message = vm.Message,
                JobId = vm.JobId
            };
        }

        public bool CompareToModel(IProposal model)
        {
            return Sender == model.Sender &&
                    Message == model.Message &&
                    JobId == model.JobId;
        }
    }
}
