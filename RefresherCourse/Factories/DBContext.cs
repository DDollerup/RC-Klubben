using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RefresherCourse.Models;

namespace RefresherCourse.Factories
{
    public class DBContext
    {
        private static volatile DBContext INSTANCE;
        public static DBContext Instance
        {
            get
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new DBContext();
                }
                return INSTANCE;
            }
        }

        private AutoFactory<Event> eventFactory;
        private AutoFactory<Product> productFactory;
        private AutoFactory<Category> categoryFactory;
        private AutoFactory<About> aboutFactory;
        private AutoFactory<Index> indexFactory;
        private AutoFactory<Slider> sliderFactory;

        public AutoFactory<Event> EventFactory
        {
            get
            {
                if (eventFactory == null)
                {
                    eventFactory = new AutoFactory<Event>();
                }
                return eventFactory;
            }
        }

        public AutoFactory<Product> ProductFactory
        {
            get
            {
                if (productFactory == null)
                {
                    productFactory = new AutoFactory<Product>();
                }
                return productFactory;
            }
        }

        public AutoFactory<Category> CategoryFactory
        {
            get
            {
                if (categoryFactory == null)
                {
                    categoryFactory = new AutoFactory<Category>();
                }
                return categoryFactory;
            }
        }

        public AutoFactory<About> AboutFactory
        {
            get
            {
                if (aboutFactory == null)
                {
                    aboutFactory = new AutoFactory<About>();
                }
                return aboutFactory;
            }
        }

        public AutoFactory<Index> IndexFactory
        {
            get
            {
                if (indexFactory == null)
                {
                    indexFactory = new AutoFactory<Index>();
                }
                return indexFactory;
            }
        }

        public AutoFactory<Slider> SliderFactory
        {
            get
            {
                if (sliderFactory == null)
                {
                    sliderFactory = new AutoFactory<Slider>();
                }
                return sliderFactory;
            }
        }
    }
}