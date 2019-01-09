const Baby = require('../models').Baby;

module.exports = {
    index: (req, res) => {
       //TODO

       Baby.findAll().then(babies => {
           res.render("baby/index", {"babies":babies})
       })
    },

    createGet: (req, res) => {
        //TODO
        res.render("baby/create")
    },

    createPost: (req, res) => {
        //TODO

        let args = req.body.baby;
        Baby.create(args).then(()=>{
            res.redirect("/")
        })
    },

    editGet: (req, res) => {
        //TODO

        let id = req.params.id;
        Baby.findById(id).then((baby => res.render("baby/edit", {"baby": baby})));
    },

    editPost: (req, res) => {
        //TODO

        let id = req.params.id;
        let args = req.body.baby;

        Baby.findById(id)
            .then(baby => baby.updateAttributes(args)
                .then(() => {res.redirect('/')}));
    },

    deleteGet: (req, res) => {
        //TODO

        let id = req.params.id;
        Baby.findById(id).then((baby => res.render("baby/delete", {"baby": baby})));
    },

    deletePost: (req, res) => {
        //TODO

        let id = req.params.id;
        Baby.findById(id)
            .then(baby => baby.destroy()
                .then(() => {res.redirect('/')}));
    }
};