# Rent A Car Application
This is a demo project created using layered architecture that I made for learning purposes during [software developer breeding camp](https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi). With this application you can simulate a car rental system like adding, deleting, updating and listing cars, brands, colors and customers.
## Introduction
* This is a simple console application. **Northwind** database for **SQL Server** is being used.
* **Entity Framework** is being used.
* There are **Business**, **DataAccess**, **Entities** and **WebFormsUI** layers.
## Insallation & Usage
* Northwind database query can be accessed via [this link](https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs).
* **EntityFramework.6.2.0** package was added to **Northwind.DataAccess** and **Northwind.WebFormsUI** layers via **NuGet Package Manager**.
* **FluentValidation** package was added to **Northwind.Business** layer via **NuGet Package Manager**.
* **Ninject** package was added to **Northwind.Business** and **Northwind.WebFormsUI** layers via **NuGet Package Manager**.
* Set Northwind.WebFormsUI Startup Project.
## Layers
🗃 Business

    📂 Abstract
         📃 IBrandService.cs
         📃 ICarService.cs
         📃 IColorService.cs
         📃 ICustomerService.cs
         📃 IRentalService.cs
         📃 IUserService.cs
         
    📂 Concrete
         📃 BrandManager.cs
         📃 CarManager.cs
         📃 ColorManager.cs
         📃 CustomerManager.cs
         📃 RentalManager.cs
         📃 UserManager.cs
         
    📂 Constants
         📃 Messages.cs        
         
    📂 DependencyResolvers
       📂 Autofac
            📃 AutofacBusinessModule.cs
         
    📂 ValidationRules
       📂 FluentValidation
            📃 BrandValidator.cs  
            📃 CarValidator.cs  
            📃 ColorValidator.cs  
            📃 CustomerValidator.cs  
            📃 RentalValidator.cs  
            📃 UserValidator.cs  
            
🗃 ConsoleUI

    📃 Program.cs            
            
🗃 Core

    📂 Aspect
       📂 Autofac
          📂 Validation
            📃 ValidationAspect.cs
         
    📂 CrossCuttingConcerns
       📂 Validation
            📃 ValidationTool.cs
            
    📂 DataAccess
       📂 EntityFramework
            📃 EfEntityRepositoryBase.cs
       📃 IEntityRepository.cs     
    
    📂 Entities
         📃 IDto.cs
         📃 IEntity.cs 
         
    📂 Utilities
       📂 Interceptors    
            📃 AspectInterceptorSelector.cs
            📃 MethodInterception.cs
            📃 MethodInterceptionBaseAttribute.cs
       📂 Results    
            📃 DataResult.cs
            📃 ErrorDataResult.cs
            📃 ErrorResult.cs
            📃 IDataResult.cs
            📃 IResult.cs
            📃 Result.cs
            📃 SuccessDataResult.cs
            📃 SuccessResult.cs
            
🗃 DataAccess

    📂 Abstract
         📃 IBrandDal.cs
         📃 ICarDal.cs
         📃 IColorDal.cs
         📃 ICustomerDal.cs
         📃 IEntityRepository.cs
         📃 IRentalDal.cs
         📃 IUserDal.cs

    📂 Concrete
       📂 EntityFramework
            📃 EfBrandDal.cs
            📃 EfCarDal.cs
            📃 EfColorDal.cs
            📃 EfCustomerDal.cs
            📃 EfRentalDal.cs
            📃 EfUserDal.cs
            📃 RentACarContext.cs
       📂 InMemory
            📃 InMemoryCarDal.cs

🗃 Entities    

    📂 Concrete
         📃 Brand.cs
         📃 Car.cs
         📃 Color.cs
         📃 Customer.cs
         📃 Rental.cs
         📃 User.cs
         
    📂 DTOs
         📃 CarDetailDto.cs
         📃 RentalDetailDto.cs

🗃 WebApi

    📂 Controllers
         📃 BrandsController.cs
         📃 CarsController.cs
         📃 ColorsController.cs
         📃 CustomersController.cs
         📃 RentalsController.cs
         📃 UsersController.cs
    📃 Program.cs
    📃 Startup.cs
## Output

![](https://cdn-images-1.medium.com/max/1200/1*9O2yDoMNel2g24HKCgok6A.png)





