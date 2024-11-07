


namespace BeautyBooking.Web.Infrastructure.ViewComponents

{
    using System.Threading.Tasks;
    using BeautyBooking.Services.Data.Cities;
    using BeautyBooking.Web.ViewModels.Cities;
    using Microsoft.AspNetCore.Mvc;

    public class CitiesSimpleListViewComponent : ViewComponent
    {
        private readonly ICitiesService citiesService;
        public CitiesSimpleListViewComponent(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var viewModel = new CitiesSimpleListViewModel
            {
                Cities = await this.citiesService.GetAllAsync<CitySimpleViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
