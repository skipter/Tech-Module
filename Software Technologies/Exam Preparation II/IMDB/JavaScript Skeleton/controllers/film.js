const Film = require('../models').Film;

module.exports = {
	index: (req, res) => {
        // TODO
		Film.findAll().then(films => res.render('film/index', {"films": films}));

	},

	createGet: (req, res) => {
        // TODO

		res.render("film/create")
	},

	createPost: (req, res) => {
        // TODO

		let args = req.body;
		Film.create(args)
			.then(() => res.redirect("/"));


	},

	editGet: (req, res) => {
        // TODO

		let id = req.params.id;
		Film.findById(id)
			.then(film => {
				res.render("film/edit", {
					"name": film.name,
					"genre": film.genre,
					"director": film.director,
					"year": film.year,
					"id": id,
				});
			}).catch(err => {
				console.log(err.message);
		})
	},

	editPost: (req, res) => {
        // TODO

		let id = req.params.id;
		console.log(id);
		let args = req.body;
		console.log(args);

		Film.findById(id)
			.then(film => {
				film.updateAttributes(args)
					.then(() => {res.redirect('/')})
			});

	},

	deleteGet: (req, res) => {
        // TODO
		let id = req.params.id;
		Film.findById(id)
			.then(film => {
				res.render("film/delete", {
					"name": film.name,
					"genre": film.genre,
					"director": film.director,
					"year": film.year,
					"id": id,
				});
			}).catch(err => {
			console.log(err.message);
		})
	},

	deletePost: (req, res) => {
        //

		let id = req.params.id;

		Film.findById(id)
			.then(Film => Film.destroy()
				.then(() => {res.redirect('/')}));
	}
};