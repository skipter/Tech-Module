const Report = require('../models').Report;

module.exports = {
    index: (req, res) => {
        //TODO

        Report.findAll().then(reports => res.render('report/index', {"reports": reports}));
    },
    createGet: (req, res) => {
        //TODO

        res.render("report/create")
    },
    createPost: (req, res) => {
        //TODO

        let body = req.body;
        Report.create(body)
            .then(()=>res.redirect('/'));
    },
    detailsGet: (req, res) => {
        //TODO

        let id = req.params.id;
        Report.findById(id).then(report =>
            res.render("report/details", {
                "status": report.status,
                "message": report.message,
                "origin": report.origin
            }));


    },
    deleteGet: (req, res) => {
        //TODO

        let id = req.params.id;
        Report.findById(id)
            .then(report => {
                res.render("report/delete", {
                    "message": report.message,
                    "origin": report.origin
                });
            });
    },
    deletePost: (req, res) => {
        //TODO

        let id = req.params.id;
        Report.findById(id)
            .then(Report => Report.destroy().then(() => {res.redirect('/')}));
    }
};