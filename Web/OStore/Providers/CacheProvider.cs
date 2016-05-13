﻿using OStore.Models.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OStore.Libs.Extensions;

namespace OStore.Providers
{
    public class CacheProvider:Library.Api.Handler.CacheHandler 
    {
        private static CacheProvider _Instance;
        public static CacheProvider Instance
        {
            get { return _Instance ?? (_Instance = new CacheProvider()); }
        }

        #region Location
        public List<SelectListItem> Provinces
        {
            get
            {
                if (!IsIncache("Provinces"))
                {
                    List<ProvinceModel> provincs = PMApi.Instance.GetProvinces();

                    var cached = provincs.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select Provinces", false);
                        if (cached != null)
                        {
                            cached.RemoveAll(item => item.Text == null);
                            SaveTocache("Provinces", cached, DateTime.Now.AddHours(10));
                        }
                    
                }
                return GetFromCache<List<SelectListItem>>("Provinces");
            }
        }

        public List<SelectListItem> Districts
        {
            get
            {
                if (!IsIncache("Districts"))
                {
                    List<DistrictModel> districts = PMApi.Instance.GetDistricts();

                    var cached = districts.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select Districts", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("Districts", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("Districts");
            }
        }

        public List<SelectListItem> SubDistricts
        {
            get
            {
                if (!IsIncache("SubDistricts"))
                {
                    List<SubDistrictModel> subDistricts = PMApi.Instance.GetSubDistricts();

                    var cached = subDistricts.ToSelectList(d => d.Name, d => d.Id.ToString(), "0", "Select SubDistricts", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("SubDistricts", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("SubDistricts");
            }
        }

        public List<SelectListItem> PostalCodes
        {
            get
            {
                if (!IsIncache("PostalCodes"))
                {
                    List<PostalCodeModel> postalCodes = PMApi.Instance.GetPostalCodes();

                    var cached = postalCodes.ToSelectList(d => d.Code, d => d.Id.ToString(), "0", "Select PostalCodes", false);
                    if (cached != null)
                    {
                        cached.RemoveAll(item => item.Text == null);
                        SaveTocache("PostalCodes", cached, DateTime.Now.AddHours(10));
                    }

                }
                return GetFromCache<List<SelectListItem>>("PostalCodes");
            }
        }
        #endregion

    }
}