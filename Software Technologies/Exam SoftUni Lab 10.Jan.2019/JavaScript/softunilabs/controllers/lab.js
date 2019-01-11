const Lab = require('../models').Lab;

module.exports = {
    index: (req, res) => {
        //TODO: Implement me

        Lab.findAll().then(labs =>{
            res.render("lab/index", {"labs":labs})
        });
    },

    createGet: (req, res) => {
        //TODO: Implement me

        res.render("lab/create")
    },

    createPost: (req, res) => {
        //TODO: Implement me

        let args = req.body.lab;
        Lab.create(args).then(()=>{
            res.redirect("/")
        })
    },

    editGet: (req, res) => {
        //TODO: Implement me

        let id = req.params.id;
        Lab.findById(id).then((lab => res.render("lab/edit", {"lab": lab})));
    },

    editPost: (req, res) => {
        //TODO: Implement me

        let id = req.params.id;
        let args = req.body.lab;

        Lab.findById(id)
            .then(lab => lab.updateAttributes(args)
                .then(() => {res.redirect('/')}));
    },

    deleteGet: (req, res) => {
        //TODO: Implement me

        let id = req.params.id;
        Lab.findById(id).then((lab => res.render("lab/delete", {"lab": lab})));
    },

    deletePost: (req, res) => {
        //TODO: Implement me

        let id = req.params.id;

        Lab.findById(id)
            .then(lab => lab.destroy()
                .then(() => {res.redirect('/')}));
    }
};