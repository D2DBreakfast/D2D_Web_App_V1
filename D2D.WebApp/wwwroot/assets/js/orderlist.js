(function($) {
  'use strict';

var dataSet1= [
    // [ "40521", "Merry",  "Hall Street", "kbc@gfail.com","Garlic Bread,AAA,BBB,CCC" ,"$43","Pending"],
    // [ "98521", "Joe",  "Hall Street", "lbc@gfail.com", " Pizza" ,"$48","Delivered"],
    // [ "45454", "Bella",  "Huston Loan", "abc@gfail.com", " Burger" ,"$43","Preaping"],
    [ "12121", " Burger-1" ,"Herry", "0987654321", "Meal Plan","Block A","Pending","$30","Sucessful" ],
    // [ "56454", " Burger-1" ,"AAA", "0987654321", "Meal Plan","Block A","Pending","$30","Sucessful"  ],
    // [ "25252", " Burger-1" ,"BBB", "0987654321", "Meal Plan","Block A","Pending","$30","Sucessful"  ],
    // [ "45454", " Burger-1" ,"CCC", "0987654321", "Meal Plan","Block A","Pending","$30","Sucessful"  ],
  //    [ "64541", "Herry",  "Jk Road", "khj@gfail.com", " Garlic Bread","$56"],
  //    [ "56562", "Bella",  "Hall Street", "lhj@gfail.com", " Garlic Bread","$36"],
    // [ "51558", "Merry",  "Hall Street", "ihj@gfail.com", " Pizza","$56"],
    // [ "55841", "Herry",  "JK Road", "mhj@gfail.com", " Garlic Bread","$56" ],
    // [ "55811", "Max",  "Hall Street", "ghj@gfail.com", " Noodles","$56" ],
    // [ "01475", "Joe",  "Street 21", "dhj@gfail.com", " Sandwich","$46"],
    // [ "55454", "Max",  "Street 21", "bhj@gfail.com", " Sandwich","$46"],
    // [ "12145", "Bella",  "Huston Loan", "abc@gfail.com", " Burger" ,"$43" ],
    // [ "52351", "Herry",  "Jk Road", "ghj@gfail.com", " Burger","$56" ],
    // [ "45823", "Joe",  "Jk Road", "abc@gfail.com", " Burger" ,"$43" ],
    // [ "98541", "Merry",  "Hall Street", "kbc@gfail.com", " Garlic Bread" ,"$43" ],
    // [ "22366", "Bella",  "Huston Loan", "abc@gfail.com", " Burger" ,"$43"],
    // [ "56465", "Jake",  "Huston Loan", "abc@gfail.com", " Burger" ,"$43"  ],
    // [ "34256", "Joe",  "Jk Road", "abc@gfail.com", " Sandwich" ,"$43"],
    // [ "45484", "Dum sum",  "Hall Street", "bbc@gfail.com", "  Pizza" ,"$43" ],
    // [ "41028","Dum sum",  "Hall Street", "bbc@gfail.com", " Pizza" ,"$43" ],
    // [ "15485", "erry",  "Jk Road", "ghj@gfail.com", " Burger","$56"],
    // [ "48568", "Bella",  "Hall Street", "lhj@gfail.com", " Garlic Bread","$36" ],
    // [ "45815", "Joe",  "Jk Road", "abc@gfail.com", "Sandwich" ,"$43"  ],
    // [ "46542", "Joe",  "Jk Road", "abc@gfail.com", "Egg Sandwich" ,"$43"  ],
    // [ "65412", "Joe",  "Hall Street", "lbc@gfail.com", "  Pizza" ,"$54" ],
    // [ "89658", "Herry",  "Jk Road", "ghj@gfail.com", " Burger","$56" ],
    // [ "02351", "Max",  "Hall Street", "ghj@gfail.com", " Noodles","$56"],
    // [ "56212", "Herry",  "New York", "ghj@gfail.com", " Garlic Bread","$56" ],
    // [ "78065", "Herry",  "New York", "ahj@gfail.com", " French Fries","$56"],
    // [ "56121", "Herry",  "New York", "ghj@gfail.com", " French Fries","$56" ],
    // [ "14526", "Lulia",  "Street 21", "ehj@gfail.com", " Pizza","$56"],
    // [ "15451", "Max",  "Hall Street", "ghj@gfail.com", "  Noodles","$56" ],
    // [ "14451", "Dum sum",  "Hall Street", "bbc@gfail.com", " Pizza" ,"$43" ]
  ];

  var tableFour = $('#data-table-4').DataTable( {
    data: dataSet1,
    columns: [
      { title: "Order ID" },
      { title: "Ordered Items" },
      { title: "Customer" },
      { title: "Phone Number" },
      { title: "Catagory" },
      { title: "Location" },
      { title: "Order Status" },
      { title: "Price" },
      { title: "Payment Status" }

    ],
  });




})(jQuery);
