(function($) {
  'use strict';
var dataSet1= [
  [ "001", "prasanna",  "9739050050", "prasannapk39@gmail.com","Hall Street", "7" ,"$43"],
  [ "98521", "Joe",  "Hall Street", "lbc@gfail.com", " Pizza" ,"$48"],
  [ "45454", "Bella",  "Huston Loan", "abc@gfail.com", " Burger" ,"$43" ],
  [ "12121", "Herry",  "Jk Road", "ghj@gfail.com", " Burger","$56" ],
  [ "56454", "Joe",  "Hall Street", "abc@gfail.com", "Garlic Bread" ,"$43" ],
  
     
  
  ];

  var tableFour = $('#data-table-4').DataTable( {
    data: dataSet1,
    columns: [
    
      { title: "id" },
      { title: "name" },
      { title: "salary" },
      { title: "Location Name" },
      { title: "Num of Orders" },
      { title: "Total Amount" }

    ],
  });







})(jQuery);
