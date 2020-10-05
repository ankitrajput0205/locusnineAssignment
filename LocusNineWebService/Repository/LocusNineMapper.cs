using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LocusNineDataAccessLayer;

namespace LocusNineWebService.Repository
{
    public class LocusNineMapper<Source, Destination>
        where Source : class
        where Destination : class
    {
        public LocusNineMapper()
        {
            Mapper.CreateMap<User, Models.User>();
            Mapper.CreateMap<Models.User, User>();

        }
        public Destination Translate(Source obj)
        {
            return Mapper.Map<Source, Destination>(obj);
        }
    }




}