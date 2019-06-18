using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BemaxWeekendTask.Models;
namespace BemaxWeekendTask.Models
{
    public class HomeVM
    {
        public List<Slider> slider { get; set; }
        public List<IconBox> IconBoxes { get; set; }
        public List<WeAreBemaxArea> weAreBemaxAreas { get; set; }
        public List<MiniSlider> miniSliders { get; set; }
        public List<WhyChooseUsArea> whyChooseUsAreas { get; set; }
        public WorkingWithOutArea working { get; set; }
        public List<LatestPost> LatestBlogPost { get; set; }
        public List<Testimonial> testimonial { get; set; }

        public List<TestimonialsBody> TestimonialsBodies{ get; set; }
        public Setting setting { get; set; }

    }
}