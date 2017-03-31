<!DOCTYPE html>
<!--[if IE 8]><html class="no-js lt-ie9" lang="en" > <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
<!--<![endif]-->
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="shortcut icon" href="/images/favicon.ico">
    <title>{{title}} | {{siteName}}</title>
    <link href='https://fonts.googleapis.com/css?family=Lato:400,700|Roboto+Slab:400,700|Inconsolata:400,700' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="/styles/theme.css" type="text/css" />
    <link rel="stylesheet" href="/styles/theme_extra.css" type="text/css" />
    <link rel="stylesheet" href="/styles/highlight.css">
    <script src="/scripts/jquery-2.1.1.min.js"></script>
    <script src="/scripts/modernizr-2.8.3.min.js"></script>
    <script type="text/javascript" src="/scripts/highlight.pack.js"></script>
	<script src="/scripts/theme.js"></script>
</head>
<body class="wy-body-for-nav" role="document">
    <div class="wy-grid-for-nav">
        <nav data-toggle="wy-nav-shift" class="wy-nav-side stickynav">
            <div class="wy-side-nav-search">
                <a href="/" class="icon icon-home"> {{siteName}}</a>
                <form id="content_search" action="search.html">
                    <span role="status" aria-live="polite" class="ui-helper-hidden-accessible"></span>
                    <input name="q" id="mkdocs-search-query" type="text" class="search_input search-query ui-autocomplete-input" placeholder="Search docs" autocomplete="off" autofocus>
                </form>
            </div>
            <div class="wy-menu wy-menu-vertical" data-spy="affix" role="navigation" aria-label="main navigation">
                <ul>
					{{#each categories}}
						<li class="toctree-l1">
							<span>{{name}}</span>
							<ul class="subnav">
								{{#each pages}}
									<li class="toctree-l1">
										<a href="{{url}}">{{title}}</a>
									</li>
								{{/each}}
							</ul>
						</li>
					{{/each}}
				</ul>
            </div>
        </nav>
        <section data-toggle="wy-nav-shift" class="wy-nav-content-wrap">
            <nav class="wy-nav-top" role="navigation" aria-label="top navigation">
                <i data-toggle="wy-nav-top" class="fa fa-bars"></i>
                <a href="#">{{siteName}}</a>
            </nav>
            <div class="wy-nav-content">
                <div class="rst-content">
                    <div role="navigation" aria-label="breadcrumbs navigation">
                        <ul class="wy-breadcrumbs">
                            <li><a href="/">Docs</a> &raquo;</li>
							<li>{{title}}</li>
                            <li class="wy-breadcrumbs-aside">
                                <a href="#" class="icon icon-github"> Edit on GitHub</a>
                            </li>
                        </ul>
                        <hr />
                    </div>
                    <div role="main">
                        <div class="section">
                            {{body}}
                        </div>
                    </div>
                    <footer>
						<div class="rst-footer-buttons" role="navigation" aria-label="footer navigation">
                            <a href="{{nextPage.url}}" class="btn btn-neutral float-right" title="{{nextPage.title}}">Next <span class="icon icon-circle-arrow-right"></span></a>
                            <a href="{{prevPage.url}}" class="btn btn-neutral" title="{{prevPage.title}}"><span class="icon icon-circle-arrow-left"></span> Previous</a>
                        </div>
                        <hr />
                        <div role="contentinfo">
                            <p>© Copyright 2017, <a href="#">{{siteName}}</a>.</p>
                        </div>
                        Built with <a href="#">mDocs</a> using a <a href="https://github.com/snide/sphinx_rtd_theme">theme</a> provided by <a href="https://readthedocs.org">Read the Docs</a>.
                    </footer>
                </div>
            </div>
        </section>
    </div>
    <div class="rst-versions" role="note" style="cursor: pointer">
        <span class="rst-current-version" data-toggle="rst-current-version">
            <a href="#" class="icon icon-github" style="float: left; color: #fcfcfc"> GitHub</a>
        </span>
    </div>
</body>
</html>
