using SzkolenieTechniczne.Projekt.Clinic.Repository;
using SzkolenieTechniczne.Projekt.Clinic.Services;

namespace SzkolenieTechniczne.Projekt.Clinic.Extensions {
    public static class ClinicExtension {
        public static IServiceCollection AddClinicServices(this IServiceCollection services) {
            services.AddScoped<IAppointmentRepository, AppointmentRepositoryBase>();
            services.AddScoped<IAppointmentService, AppointmentService>();
            return services;
        }
    }
}
