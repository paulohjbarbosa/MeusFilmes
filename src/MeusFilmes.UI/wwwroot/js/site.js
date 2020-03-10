// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(window).scroll(function(){
    if ($(window).scrollTop() >= 120) {
       $('nav').addClass('nav-after');
       
    }
    else {
       $('nav').removeClass('nav-after');

    }
});

$(document).ready( function () {



   $('.dataTable').DataTable({
      "language": {
         "url": "//cdn.datatables.net/plug-ins/1.10.20/i18n/Portuguese-Brasil.json"
      }
   });
} );

