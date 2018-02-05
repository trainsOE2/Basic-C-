var parseDate = d3.timeFormat("%B %d, %Y");
d3.csv("data.csv")
    .row(function(d){
        return {
            date:parseDate(d.Joining), age:(d.Age)
        }
    })
    .get(function(err, data){
        console.log(data);
    });