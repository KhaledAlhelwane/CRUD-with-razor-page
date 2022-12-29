using Microsoft.EntityFrameworkCore;
using PersonalProfit.Data;

namespace PersonalProfit.Model
{
    public class SeedData
    {
    //    public static void Initialize(IServiceProvider serviceProvider)
    //    {
    //        using (var context = new PersonalProfitContext(
    //            serviceProvider.GetRequiredService<
    //                DbContextOptions<PersonalProfitContext>>()))
    //        {
    //            if (context == null || context.User == null)
    //            {
    //                throw new ArgumentNullException("Null RazorPagesMovieContext");
    //            }

    //            // Look for any movies.
    //            if (context.User.Any())
    //            {
    //                return;   // DB has been seeded
    //            }

    //            context.User.AddRange(
    //                new User
    //                {Date=DateTime.Now.Date,
    //                Allamount=1000,
    //                MonthlyPyment=1000,
    //                Name="Profit",
    //                PrecentageProfit=100,
    //                RemainingQuantity=10
    //                },
    //                new User
    //                {
    //                    Date = DateTime.Now.Date,
    //                    Allamount = 1000,
    //                    MonthlyPyment = 1000,
    //                    Name = "Profit",
    //                    PrecentageProfit = 100,
    //                    RemainingQuantity = 10
    //                },
    //                   new User
    //                    {
    //                       Date = DateTime.Now.Date,
    //                        Allamount = 1000,
    //                        MonthlyPyment = 1000,
    //                         Name = "Profit",
    //                         PrecentageProfit = 100,
    //                         RemainingQuantity = 10
    //                   },
    //                    new User
    //                   {
    //                   Date = DateTime.Now.Date,
    //                     Allamount = 1000,
    //                       MonthlyPyment = 1000,
    //                     Name = "Profit",
    //                     PrecentageProfit = 100,
    //                     RemainingQuantity = 10
    //                    }

    //            );
    //            context.SaveChanges();
    //        }
    //    }
    }
}
