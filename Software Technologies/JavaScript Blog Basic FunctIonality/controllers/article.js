const Article = require('../models').Article;



module.exports = {
    createGet: (req, res) => {
        res.render('article/create');
    },

    createPost: (req, res) => {
        let articleArgs = req.body;
        console.log("req.body");
        console.log(articleArgs);

        let errorMsg = '';

        if (!req.isAuthenticated) {
            errorMsg = 'You should be logged in to make article!'
        } else if (!articleArgs.title) {
            errorMsg = 'Invalid title!';
        } else if (!articleArgs.content) {
            errorMsg = 'Invalid content!'
        }

        if (errorMsg) {
            articleArgs.error = errorMsg;
            res.render('article/create', articleArgs);
        }

        articleArgs.authorId = req.user.id;

        Article.create(articleArgs).then(article => {
            res.redirect('/');
        }).catch(err => {
            console.log(err.message);
            res.render('article/create', {error: err.message});
        });
    },

    details: (req, res) => {
        let id = req.params.id;
        Article.findById(id, {include: [{model: User}]
        }).then(articles => {
            res.render('article/details', article.dataValues)
        });
    }
};