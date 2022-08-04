using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectTXServer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTXServer.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {


            //Id for product id
            var product1 = Guid.NewGuid().ToString();
            var product2 = Guid.NewGuid().ToString();
            var product3 = Guid.NewGuid().ToString();
            var product4 = Guid.NewGuid().ToString();
            var product5 = Guid.NewGuid().ToString();
            var product6 = Guid.NewGuid().ToString();
            var product7 = Guid.NewGuid().ToString();
            var product8 = Guid.NewGuid().ToString();
            var product9 = Guid.NewGuid().ToString();
            var product10 = Guid.NewGuid().ToString();
            var product11 = Guid.NewGuid().ToString();
            var product12 = Guid.NewGuid().ToString();
            var product13 = Guid.NewGuid().ToString();
            var product14 = Guid.NewGuid().ToString();
            var product15 = Guid.NewGuid().ToString();
            var product16 = Guid.NewGuid().ToString();
            var product17 = Guid.NewGuid().ToString();
            var product18 = Guid.NewGuid().ToString();
            var product19 = Guid.NewGuid().ToString();
            var product20 = Guid.NewGuid().ToString();
            var product21 = Guid.NewGuid().ToString();
            var product22 = Guid.NewGuid().ToString();
            var product23 = Guid.NewGuid().ToString();
            var product24 = Guid.NewGuid().ToString();
            var product25 = Guid.NewGuid().ToString();
            var product26 = Guid.NewGuid().ToString();
            var product27 = Guid.NewGuid().ToString();
            var product28 = Guid.NewGuid().ToString();


            //Table Products
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = product1,
                    ProductName = "Spider Man",
                    ProductCover = "css/images/vangioitienlung.PNG",
                    ProductDescription = "This is Spider Man Product",
                    ProductIntro = "link clip",
                    ProductRate = 1
                },
                new Product()
                {
                    ProductId = product2,
                    ProductName = "Mavel",
                    ProductCover = "css/images/dauladailuc.PNG",
                    ProductDescription = "This is Mavel Product",
                    ProductIntro = "link clip",
                    ProductRate = 1
                }
                ,
                new Product()
                {
                    ProductId = product3,
                    ProductName = "Tom And Jerry",
                    ProductCover = "css/images/Thegioihoanmy.PNG",
                    ProductDescription = "This is Tom And Jerry Product",
                    ProductIntro = "link clip",
                    ProductRate = 3
                },
                new Product()
                {
                    ProductId = product4,
                    ProductName = "Connan",
                    ProductCover = "css/images/yeuthanky.PNG",
                    ProductDescription = "This is Connan Product",
                    ProductIntro = "link clip",
                    ProductRate = 3
                },
                new Product()
                {
                    ProductId = product5,
                    ProductName = "Sogoku1",
                    ProductCover = "css/images/dauphathuongkhung.PNG",
                    ProductDescription = "This is Songoku1 Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product6,
                    ProductName = "Naruto1",
                    ProductCover = "css/images/vothanchuate.PNG",
                    ProductDescription = "This is naruto1 Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product7,
                    ProductName = "YourName",
                    ProductCover = "css/images/movie15.jpg",
                    ProductDescription = "This is YourName Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product8,
                    ProductName = "Kamen Rider",
                    ProductCover = "css/images/movie14.jpg",
                    ProductDescription = "This is Kamen Rider Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product9,
                    ProductName = "Naruto2",
                    ProductCover = "css/images/movie13.jpg",
                    ProductDescription = "This is Naruto2 Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product10,
                    ProductName = "Songoku2",
                    ProductCover = "css/images/movie12.jpg",
                    ProductDescription = "This is Songoku2 Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product11,
                    ProductName = "Songoku2",
                    ProductCover = "css/images/movie11.jpg",
                    ProductDescription = "This is Songoku2 Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product12,
                    ProductName = "Đấu La Đại Lục",
                    ProductCover = "css/images/movie10.jpg",
                    ProductDescription = "This is Đấu La Đại Lục Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product13,
                    ProductName = "Yêu Thần Ký",
                    ProductCover = "css/images/movie9.jpg",
                    ProductDescription = "This is Yêu Thần Ký Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product14,
                    ProductName = "Vạn Giới Thần Chủ",
                    ProductCover = "css/images/movie8.jpg",
                    ProductDescription = "This is Vạn Giới Thần Chủ Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product15,
                    ProductName = "Võ Thần Chúa Tể",
                    ProductCover = "css/images/movie7.jpg",
                    ProductDescription = "This is Võ Thần Chúa Tể Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product16,
                    ProductName = "Vạn Giới Tiên Lung",
                    ProductCover = "css/images/movie6.jpg",
                    ProductDescription = "This is Vạn Giới Tiên Lung Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product17,
                    ProductName = "Tru Tiên",
                    ProductCover = "css/images/movie5.jpg",
                    ProductDescription = "This is Tru Tiên Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product18,
                    ProductName = "Nghịch Thiên Chí Tôn",
                    ProductCover = "css/images/movie4.jpg",
                    ProductDescription = "This is Nghịch Thiên Chí Tôn Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product19,
                    ProductName = "Thế Giới Hoàn Mỹ",
                    ProductCover = "css/images/movie3.jpg",
                    ProductDescription = "This is Thế Giới Hoàn Mỹ Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                },
                new Product()
                {
                    ProductId = product20,
                    ProductName = "Đấu Phá Thương Khung",
                    ProductCover = "css/images/movie2.jpg",
                    ProductDescription = "This is Đấu Phá Thương Khung Product",
                    ProductIntro = "link clip",
                    ProductRate = 5
                });
         


        //Table About
        //builder.Entity<About>().HasData(
        //        new About()
        //        {
        //            about_id=1,
        //            about_Url= "https://www.youtube.com/watch?v=F1vcruph8JA",
        //            about_Title = "Footwear the leading eCommerce Store around the Globe",
        //            about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
        //        });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 
            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name ="Staff",
                    Description = "Staff",
                    NormalizedName = "staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "Admin",
                    Description = "Admin",
                    NormalizedName = "admin"

                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "DE544998-A3CC-4E12-ABB4-0642E57BD222";

            //Table AppUser 
            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(
            new AppUser
            {
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserFirstName = "admin first name",
                UserLastName = "admin last name",
                UserPhoneNumber = "08658568790",
                UserDoB = new DateTime(2020, 01, 02)
                
            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "STAFF@GMAIL.COM",
                NormalizedEmail = "STAFF@GMAIL.COM",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UserFirstName = "staff first name",
                UserLastName = "staff last name",
                UserPhoneNumber = "08658568790",
                UserDoB = new DateTime(2020, 01, 02)
            });


            //Table AppUser - role 
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });





            //var IdCart1 = "72309286-ECBB-4D20-AD95-2819D31E3400";
            //var IdCart2 = "D355458F-1DD3-4834-AA28-6DA34B6357FF";


            //Table Cart

            //builder.Entity<Cart>().HasData(
            //    new Cart()
            //    {
            //        cart_Id = IdCart1,
            //        cart_UserID = IdStaff

            //    },
            //    new Cart()
            //    {
            //        cart_Id = IdCart2,
            //        cart_UserID = IdAdmin

            //    });


            //Table Product In Cart


            // Set id for Categories
            var ifProductType1 = Guid.NewGuid().ToString();
            var ifProductType2 = Guid.NewGuid().ToString();
            //var ifProductType3 = Guid.NewGuid().ToString();
            //var ifProductType4 = Guid.NewGuid().ToString();
            //var ifProductType5 = Guid.NewGuid().ToString();


            //Table Categories
            builder.Entity<ProductType>().HasData(
                new ProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductTypeName = "Romantic",

                },
                new ProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductTypeName = "Action",



                });
            //new ProductType()
            //{
            //    ProductTypeId = ifProductType3,
            //    ProductTypeName = "Action",



            //},
            //new ProductType()
            //{
            //    ProductTypeId = ifProductType4,
            //    ProductTypeName = "Romantic",



            //},
            //new ProductType()
            //{
            //    ProductTypeId = ifProductType5,
            //    ProductTypeName = "Action",



            //});








            //Table ContactUsers
            //var contactUser = Guid.NewGuid().ToString();

            //builder.Entity<ContactUsers>().HasData(
            //    new ContactUsers()
            //    {
            //        cu_Id = contactUser.ToString(),
            //        cu_FirstName = "FirstName",
            //        cu_LastName = "LastName",
            //        cu_Email = "Email",
            //        cu_Subject = "Subject",
            //        cu_Description = "Description"
            //    });


            //var ReviewId1 = "EEBA6608-AB75-4E83-909F-604B1A06F16C";
            //var ReviewId2 = "9EED8607-D2BB-45EE-AEE3-C59D858A7F97";
            //var ReviewId3 = "C2A543C2-B1E2-4DC5-A131-9137E4673FA6";




            //Table Reviews new DateTime(2020, 01, 02)


            //builder.Entity<Reviews>().HasData(
            //    new Reviews()
            //    {
            //        review_id = ReviewId1,
            //        review_Comment = "Good1",
            //        review_UserId = IdAdmin,
            //        review_UploadTime = new DateTime(2020, 01, 02),
            //        review_HideStatus = false,
            //        review_ReviewType = "Review"

            //    },
            //    new Reviews()
            //    {
            //        review_id = ReviewId2,
            //        review_Comment = "Good2",
            //        review_UserId = IdStaff,
            //        review_UploadTime = new DateTime(2020, 01, 02),
            //        review_HideStatus = false,
            //        review_ReviewType = "Review"

            //    },
            //    new Reviews()
            //    {
            //        review_id = ReviewId3,
            //        review_Comment = "Good3",
            //        review_UserId = IdAdmin,
            //        review_UploadTime = new DateTime(2020, 01, 02),
            //        review_HideStatus = false,
            //        review_ReviewType = "Review"

            //    });

            //var SubReviewId1 = Guid.NewGuid().ToString(); 
            //var SubReviewId2 = Guid.NewGuid().ToString();
            //var SubReviewId3 = Guid.NewGuid().ToString();


            // Table SubReview 

            //builder.Entity<SubReview>().HasData(
            //    new SubReview()
            //    {
            //        subReview_Id = SubReviewId1,
            //        subReview_UserId = IdAdmin,
            //        subReview_Commnet = "subreview 1",
            //        subReview_DateCommnet = new DateTime(2020, 01, 02),
            //        subReview_HideStatus = false,
            //        subreview_SubReviewType = "SubReview"
            //    },
            //    new SubReview()
            //    {
            //        subReview_Id = SubReviewId2,
            //        subReview_UserId = IdStaff,
            //        subReview_Commnet = "subreview 3",
            //        subReview_DateCommnet = new DateTime(2020, 01, 03),
            //        subReview_HideStatus = false,
            //        subreview_SubReviewType = "SubReview"
            //    },
            //    new SubReview()
            //    {
            //        subReview_Id = SubReviewId3,
            //        subReview_UserId = IdAdmin,
            //        subReview_Commnet = "subreview 3",
            //        subReview_DateCommnet = new DateTime(2020, 01, 03),
            //        subReview_HideStatus = false,
            //        subreview_SubReviewType = "SubReview"
            //    }
            //    );

            //builder.Entity<SubReviewInReview>().HasData(
            //    new SubReviewInReview()
            //    {
            //        SRiR_ReviewId = ReviewId1,
            //        SRiR_SubReviewId = SubReviewId1
            //    },
            //    new SubReviewInReview()
            //    {
            //        SRiR_ReviewId = ReviewId1,
            //        SRiR_SubReviewId = SubReviewId2
            //    },
            //    new SubReviewInReview()
            //    {
            //        SRiR_ReviewId = ReviewId2,
            //        SRiR_SubReviewId = SubReviewId3
            //    }
            //    );

            //Table ProductInCategories
            builder.Entity<ProductInProductType>().HasData(
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product7
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product8
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product10
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product11
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product12
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product13
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product14
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType1,
                    ProductId = product16
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product1
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product4
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product5
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product6
                },
                new ProductInProductType()
                {
                    ProductTypeId = ifProductType2,
                    ProductId = product19
                });
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType3,
                //    ProductId = product23
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType3,
                //    ProductId = product24
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType3,
                //    ProductId = product26
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType3,
                //    ProductId = product27
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType4,
                //    ProductId = product2
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType4,
                //    ProductId = product18
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product3
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product9
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product15
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product17
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product20
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product21
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product22
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product25
                //},
                //new ProductInProductType()
                //{
                //    ProductTypeId = ifProductType5,
                //    ProductId = product28
                //});


            //Table ReviewInproduct



            //builder.Entity<ReviewInproduct>().HasData(
            //    new ReviewInproduct()
            //    {
            //        rip_ProductId = product1,
            //        rip_ReviewId = ReviewId1,
            //    },
            //    new ReviewInproduct()
            //    {
            //        rip_ProductId = product1,
            //        rip_ReviewId = ReviewId2,
            //    },
            //    new ReviewInproduct()
            //    {
            //        rip_ProductId = product1,
            //        rip_ReviewId = ReviewId3,
            //    });


            //builder.Entity<Coupons>().HasData(
            //    new Coupons()
            //    {
            //        couponId = Guid.NewGuid().ToString(),
            //        couponCode ="code10",
            //        couponPrice = 10
            //    },
            //    new Coupons()
            //    {
            //        couponId = Guid.NewGuid().ToString(),
            //        couponCode = "code50",
            //        couponPrice = 50
            //    });



            //string billId1 = "D269BF93-A5E2-4C4A-8146-9967DDE80D30";

            ////Table Bills

            //builder.Entity<Bills>().HasData(
            //    new Bills()
            //    {
            //        bill_Id = billId1,
            //        bill_UserId = IdStaff,
            //        bill_PaidTotal = 2000,
            //        bill_ProductIdlist = "1|2|3|4",
            //        bill_ProductNamelist = "product 1|product 2| product 3| product 4|",
            //        bill_ProductPricelist = "550|450|350|640|",
            //        bill_Shipping = 10,
            //        bill_Discount = 0,
            //        bill_Confirmation = true,
            //        bill_DatetimeOrder = DateTime.Now,
            //        bill_PaymentMethod = "Check Payment",
            //        bill_Note = "",
            //        bill_Quantity = "1|1|2|1|",
            //        bill_HideStatus = false,
            //        bill_WaitForConfirmation = false,
            //        bill_WaitPickup = false,
            //        bill_Delivering = false,
            //        bill_Delivered =  false,
            //        bill_Cancelled = false
            //    }); ;

            //Table Shiping

            //string shipId = "7CF94A7D-9239-446E-A404-086518F84652";

            //builder.Entity<Shipping>().HasData(
            //    new Shipping()
            //    {
            //        ship_Id = shipId,
            //        ship_Name ="Ship",
            //        ship_Price = 5
            //    });

            ////Table Contact System

            //var ContactSystemId = Guid.NewGuid().ToString();

            //builder.Entity<ContactSystem>().HasData(
            //    new ContactSystem()
            //    {
            //        Contact_Id = ContactSystemId,
            //        Contact_Address = "Huntsville, AL 35813, USA",
            //        Contact_Description = "Prof Lord John Krebs provides a brief history of human food, from our remote ancestors 3 million years ago to the present day. By looking at the four great transitions in human food - cooking, agriculture, processing, and preservation - he considers a variety of questions, including why people like some kinds of foods and not others; how your senses contribute to flavor; the role of genetics in our likes and dislikes; and the differences in learning and culture around the world.",
            //        Contact_Email = "support@foodshop.com ",
            //        Contact_Phone = "021.343.7575"
            //    });


        }    
                
               
    }   
}
