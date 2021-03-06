var mongoose = require('mongoose');
var author = mongoose.model('author');
module.exports={
    get:function (req, res) {
        author.find({}, function (err, authors) {
            if (err) {
                res.json({
                    message: "Error",
                    error: err
                })
            } else {
                res.json({
                    message: "success",
                    data: authors
                })
    
            }
        })
    },
    getone:function(req,res){
        author.findOne({_id:req.params.id},function(err,author){
            console.log(author);
            if (err){
                console.log(err)
                res.json({
                    message: "Error",
                    error: err
                })
            }
            else{
                res.json({
                    message: "Success",
                    data:author
                });
            }
        })
    },
    create:function(req,res){
        author.create({name:req.body.name},function(err){
            console.log(req.body);
            if (err){
                console.log(err)
                res.json({
                    message: "Error",
                    error: err
                })
            }
            else{
                res.redirect('/');
            }
        })
    },
    update:function(req,res){
        author.findOne({_id:req.params.id},function(err,x){
            console.log(req.body);
            if (err){
                console.log(err)
                res.json({
                    message: "Error",
                    error: err
                })
            }
            else{
                x.name=req.body.name;
                x.save();
                res.redirect('/');
            }
        })
    },
    delete:function(req,res){
        author.deleteOne({_id:req.params.id},function(err){
            if (err){
                console.log(err)
                res.json({
                    message: "Error",
                    error: err
                })
            }
            else{
                res.json({message:"success"});
            }
        })
    }
}