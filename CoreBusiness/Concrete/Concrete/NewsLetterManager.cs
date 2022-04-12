using CoreBusiness.Abstract;
using CoreData.Abstract;
using CoreEntity.Concrete;
using System;

namespace CoreBusiness.Concrete.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterRepository newsletterRepository;

        public NewsLetterManager(INewsLetterRepository newsletterRepository)
        {
            this.newsletterRepository = newsletterRepository;
        }

        public void Add(NewsLetter newsLetter)
        {
            newsletterRepository.Add(newsLetter);
        }
    }
}
