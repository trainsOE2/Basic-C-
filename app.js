var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var mongoose = require('mongoose');
var csv = require("csvtojson");
const csvFilePath = "C:/Users/Z003wc1d/WebstormProjects/restAPI/models/FSI/realSample.txt";


mongoose.connect('mongodb://localhost:27017/my_database');

// Get Mongoose to use the global promise library
mongoose.Promise = global.Promise;
//Get the default connection
var db = mongoose.connection;

//Define table Schema
var Schema = mongoose.Schema;

var SomeModelSchema = new Schema({
  //1/31/2017,11:01:00 PM.488,FCG3_Avg_Crrnt_0_FSI1,805.0,SPONT
    date: Date,
    time: Date,
    device: String,
    value: Number,
    type: String
});

// Compile model from schema
var SomeModel = mongoose.model('SomeModel', SomeModelSchema );

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

     // Create an instance of model SomeModel
     var awesome_instance = new SomeModel({ date: obj.date, time: obj.time,
                                            device: obj.device, value: obj.current_value,
                                            type: obj.type});

        // Save the new model instance, passing a callback
    awesome_instance.save(function (err) {
      if (err) {return handleError(err);}
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
app.get('/', function(req, res) {
  res.send("Hello Seattle\n");
  console.log("Running on port " + port);
});

app.get('/device/:name', function(req, res) {

   // Get /musician/Matt
   console.log(req.params.name)
   // => Matt
   SomeModel.find({device: req.params.name}, function(err, obj) {
     if (obj) {
      console.log(obj[0].device);  // 1234
      console.log(obj[0].value);  // 1234

      res.send({"device": obj[0].device,"value":obj[0].value});
    }
   })


});



//var app = express();

/*var myJson = new Schema({
  request: String,
  time: Number
},
{
  collection: 'outputJSON'
});

var Model = mongoose.model('Model', myJson); */


/*app.get('/save/:query', cors(), function(req, res){
  var query = req.params.query;
  var savedata = new Model({
    'request': query,
    'time': Math.floor(Date.now()/1000)
  }).save(function(err, result){
    if (err){
      throw err;
    }
    if(result){
//      res.json(result);
    }
  })
})

app.get('/find/:query', cors(), function(req, res){
  var query = req.params.query;

  Model.find({
    'request': query
  }, function(err, result){
    if(err){
      throw err;
    }
    if(result) {
      res.json(result)
    }
    else{
      res.send(JSON.stringify({
        error: 'ERROR'
      }))
    }
  })
})
*/
