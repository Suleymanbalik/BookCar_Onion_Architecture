using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.Domain.Entities
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string TestimonialFullName { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImagUrl { get; set; }
    }
}
