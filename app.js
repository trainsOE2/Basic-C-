var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var mongoose = require('mongoose');
var csv = require("csvtojson");

//base file source on local machine
const csvFilePath = "C:/Users/Z003wc1d/WebstormProjects/restAPI/models/FSI/realSample.txt";

//connect to database on mlab
mongoose.connect('mongodb://dbuser:dbpass@ds235768.mlab.com:35768/temp');

// Get Mongoose to use the global promise library
mongoose.Promise = global.Promise;

//Get the default connection
var db = mongoose.connection;

//Define table Schema
var Schema = mongoose.Schema;

var model_v2Schema = new Schema({
  timeStamp: String,
  device: String,
  value: Number,
  type: String
});
var model_v2 = mongoose.model('model_v2', model_v2Schema);

// Convert a csv file with csvtojson
csv({
      noheader: true,
      delimiter: ';',
      headers: ['date','time','device','current_value','type']
  })
  .fromFile(csvFilePath)
  .on("end_parsed",function(list_obj){

      list_obj.forEach(function(obj) {

           console.log(obj);
           //Conversion to 24 hour clock format
           var hour = parseInt(obj.time.slice(0,2));
           hour += 12;
           var hh = " ";
           if(hour == 24){
              hh = "00";
           }
           //Declaration of ISODate attributes (time)
           else{
            hh = hour.toString();
           }
           var mi = obj.time.slice(3, 5);
           var ss = obj.time.slice(6, 8);
           var xyzZ = obj.time.slice(11, 15);

           //Declaration of ISODate attributes (date)
           var str = obj.date;
           var yyyy = str.substring(str.lastIndexOf('/')+1, str.length);
           var mm = str.substring(0, str.indexOf('/'));
           var dd = str.substring(str.indexOf('/')+1, str.lastIndexOf('/'));

           //format check for month
           var month = parseInt(mm);
           if(month < 10)
           {
             mm = '0' + mm;
           }
           //format check for date
           var day = parseInt(dd);
           if(day < 10)
           {
             dd = '0' + dd;
           }

           var dateValue = yyyy + '-' + mm + '-' + dd + 'T' + hh + ':' + mi + ':' + ss + xyzZ + 'Z';

           // Create an instance of model model_v2
           var awesome_instance = new model_v2({ timeStamp: dateValue,
                                                  device: obj.device, value: obj.current_value,
                                                  type: obj.type});

            // Save the new model instance, passing a callback
            awesome_instance.save(function (err) {
                if (err) {
                  return console.log(err);
                }
                else {
                  console.log('saved');
                }
            });

      })

  })


var port = process.env.PORT || 8080;
app.listen(port, function() {
  console.log("Running on port " + port);
});

