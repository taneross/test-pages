/*  Teachscape Burgundy */

/*! normalize.css v2.1.3 | MIT License | git.io/normalize */

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
nav,
section,
summary {
  display: block;
}

audio,
canvas,
video {
  display: inline-block;
}

audio:not([controls]) {
  display: none;
  height: 0;
}

[hidden],
template {
  display: none;
}

html {
  font-family: sans-serif;
  -webkit-text-size-adjust: 100%;
      -ms-text-size-adjust: 100%;
}

body {
  margin: 0;
}

a {
  background: transparent;
}

a:focus {
  outline: thin dotted;
}

a:active,
a:hover {
  outline: 0;
}

h1 {
  margin: 0.67em 0;
  font-size: 2em;
}

abbr[title] {
  border-bottom: 1px dotted;
}

b,
strong {
  font-weight: bold;
}

dfn {
  font-style: italic;
}

hr {
  height: 0;
  -moz-box-sizing: content-box;
       box-sizing: content-box;
}

mark {
  color: #000;
  background: #ff0;
}

code,
kbd,
pre,
samp {
  font-family: monospace, serif;
  font-size: 1em;
}

pre {
  white-space: pre-wrap;
}

q {
  quotes: "\201C" "\201D" "\2018" "\2019";
}

small {
  font-size: 80%;
}

sub,
sup {
  position: relative;
  font-size: 75%;
  line-height: 0;
  vertical-align: baseline;
}

sup {
  top: -0.5em;
}

sub {
  bottom: -0.25em;
}

img {
  border: 0;
}

svg:not(:root) {
  overflow: hidden;
}

figure {
  margin: 0;
}

fieldset {
  padding: 0.35em 0.625em 0.75em;
  margin: 0 2px;
  border: 1px solid #c0c0c0;
}

legend {
  padding: 0;
  border: 0;
}

button,
input,
select,
textarea {
  margin: 0;
  font-family: inherit;
  font-size: 100%;
}

button,
input {
  line-height: normal;
}

button,
select {
  text-transform: none;
}

button,
html input[type="button"],
input[type="reset"],
input[type="submit"] {
  cursor: pointer;
  -webkit-appearance: button;
}

button[disabled],
html input[disabled] {
  cursor: default;
}

input[type="checkbox"],
input[type="radio"] {
  padding: 0;
  box-sizing: border-box;
}

input[type="search"] {
  -webkit-box-sizing: content-box;
     -moz-box-sizing: content-box;
          box-sizing: content-box;
  -webkit-appearance: textfield;
}

input[type="search"]::-webkit-search-cancel-button,
input[type="search"]::-webkit-search-decoration {
  -webkit-appearance: none;
}

button::-moz-focus-inner,
input::-moz-focus-inner {
  padding: 0;
  border: 0;
}

textarea {
  overflow: auto;
  vertical-align: top;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

@media print {
  * {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    box-shadow: none !important;
  }
  a,
  a:visited {
    text-decoration: underline;
  }
  a[href]:after {
    content: " (" attr(href) ")";
  }
  abbr[title]:after {
    content: " (" attr(title) ")";
  }
  .ir a:after,
  a[href^="javascript:"]:after,
  a[href^="#"]:after {
    content: "";
  }
  pre,
  blockquote {
    border: 1px solid #999;
    page-break-inside: avoid;
  }
  thead {
    display: table-header-group;
  }
  tr,
  img {
    page-break-inside: avoid;
  }
  img {
    max-width: 100% !important;
  }
  @page  {
    margin: 2cm .5cm;
  }
  p,
  h2,
  h3 {
    orphans: 3;
    widows: 3;
  }
  h2,
  h3 {
    page-break-after: avoid;
  }
  .navbar {
    display: none;
  }
  .table td,
  .table th {
    background-color: #fff !important;
  }
  .btn > .caret,
  .dropup > .btn > .caret {
    border-top-color: #000 !important;
  }
  .label {
    border: 1px solid #000;
  }
  .table {
    border-collapse: collapse !important;
  }
  .table-bordered th,
  .table-bordered td {
    border: 1px solid #ddd !important;
  }
}

*,
*:before,
*:after {
  -webkit-box-sizing: border-box;
     -moz-box-sizing: border-box;
          box-sizing: border-box;
}

html {
  font-size: 62.5%;
  -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
}

body {
  font-family: Arial, sans-serif;
  font-size: 16px;
  line-height: 1.428571429;
  color: #333333;
  background-color: #ffffff;
}

input,
button,
select,
textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}

a {
  color: #2f4fa2;
  text-decoration: none;
}

a:hover,
a:focus {
  color: #1e3267;
  text-decoration: underline;
}

a:focus {
  outline: thin dotted #333;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

img {
  vertical-align: middle;
}

.img-responsive {
  display: block;
  height: auto;
  max-width: 100%;
}

.img-rounded {
  border-radius: 0.5em;
}

.img-thumbnail {
  display: inline-block;
  height: auto;
  max-width: 100%;
  padding: 4px;
  line-height: 1.428571429;
  background-color: #ffffff;
  border: 1px solid #dddddd;
  border-radius: 0.5em;
  -webkit-transition: all 0.2s ease-in-out;
          transition: all 0.2s ease-in-out;
}

.img-circle {
  border-radius: 50%;
}

hr {
  margin-top: 22px;
  margin-bottom: 22px;
  border: 0;
  border-top: 1px solid #eeeeee;
}

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  padding: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0 0 0 0);
  border: 0;
}

p {
  margin: 0 0 11px;
}

.lead {
  margin-bottom: 22px;
  font-size: 18px;
  font-weight: 200;
  line-height: 1.4;
}

@media (min-width: 768px) {
  .lead {
    font-size: 24px;
  }
}

small,
.small {
  font-size: 85%;
}

cite {
  font-style: normal;
}

.text-muted {
  color: #999999;
}

.text-primary {
  color: #732843;
}

.text-primary:hover {
  color: #4d1b2d;
}

.text-warning {
  color: #c09853;
}

.text-warning:hover {
  color: #a47e3c;
}

.text-danger {
  color: #b94a48;
}

.text-danger:hover {
  color: #953b39;
}

.text-success {
  color: #468847;
}

.text-success:hover {
  color: #356635;
}

.text-info {
  color: #3a87ad;
}

.text-info:hover {
  color: #2d6987;
}

.text-left {
  text-align: left;
}

.text-right {
  text-align: right;
}

.text-center {
  text-align: center;
}

h1,
h2,
h3,
h4,
h5,
h6,
.h1,
.h2,
.h3,
.h4,
.h5,
.h6 {
  font-family: Arial, sans-serif;
  font-weight: normal;
  line-height: 1.1;
  color: inherit;
}

h1 small,
h2 small,
h3 small,
h4 small,
h5 small,
h6 small,
.h1 small,
.h2 small,
.h3 small,
.h4 small,
.h5 small,
.h6 small {
  font-weight: normal;
  line-height: 1;
  color: #999999;
}

h1,
h2,
h3 {
  margin-top: 22px;
  margin-bottom: 11px;
}

h1 small,
h2 small,
h3 small {
  font-size: 65%;
}

h4,
h5,
h6 {
  margin-top: 11px;
  margin-bottom: 11px;
}

h4 small,
h5 small,
h6 small {
  font-size: 75%;
}

h1,
.h1 {
  font-size: 41px;
}

h2,
.h2 {
  font-size: 34px;
}

h3,
.h3 {
  font-size: 28px;
}

h4,
.h4 {
  font-size: 20px;
}

h5,
.h5 {
  font-size: 16px;
}

h6,
.h6 {
  font-size: 14px;
}

.page-header {
  padding-bottom: 10px;
  margin: 44px 0 22px;
  border-bottom: 1px solid #eeeeee;
}

ul,
ol {
  margin-top: 0;
  margin-bottom: 11px;
}

ul ul,
ol ul,
ul ol,
ol ol {
  margin-bottom: 0;
}

.list-unstyled {
  padding-left: 0;
  list-style: none;
}

.list-inline {
  padding-left: 0;
  list-style: none;
}

.list-inline > li {
  display: inline-block;
  padding-right: 5px;
  padding-left: 5px;
}

dl {
  margin-bottom: 22px;
}

dt,
dd {
  line-height: 1.428571429;
}

dt {
  font-weight: bold;
}

dd {
  margin-left: 0;
}

@media (min-width: 768px) {
  .dl-horizontal dt {
    float: left;
    width: 160px;
    overflow: hidden;
    clear: left;
    text-align: right;
    text-overflow: ellipsis;
    white-space: nowrap;
  }
  .dl-horizontal dd {
    margin-left: 180px;
  }
  .dl-horizontal dd:before,
  .dl-horizontal dd:after {
    display: table;
    content: " ";
  }
  .dl-horizontal dd:after {
    clear: both;
  }
  .dl-horizontal dd:before,
  .dl-horizontal dd:after {
    display: table;
    content: " ";
  }
  .dl-horizontal dd:after {
    clear: both;
  }
}

abbr[title],
abbr[data-original-title] {
  cursor: help;
  border-bottom: 1px dotted #999999;
}

abbr.initialism {
  font-size: 90%;
  text-transform: uppercase;
}

blockquote {
  padding: 11px 22px;
  margin: 0 0 22px;
  border-left: 5px solid #eeeeee;
}

blockquote p {
  font-size: 20px;
  font-weight: 300;
  line-height: 1.25;
}

blockquote p:last-child {
  margin-bottom: 0;
}

blockquote small {
  display: block;
  line-height: 1.428571429;
  color: #999999;
}

blockquote small:before {
  content: '\2014 \00A0';
}

blockquote.pull-right {
  padding-right: 15px;
  padding-left: 0;
  border-right: 5px solid #eeeeee;
  border-left: 0;
}

blockquote.pull-right p,
blockquote.pull-right small {
  text-align: right;
}

blockquote.pull-right small:before {
  content: '';
}

blockquote.pull-right small:after {
  content: '\00A0 \2014';
}

blockquote:before,
blockquote:after {
  content: "";
}

address {
  margin-bottom: 22px;
  font-style: normal;
  line-height: 1.428571429;
}

code,
kdb,
pre,
samp {
  font-family: Monaco, Menlo, Consolas, "Courier New", monospace;
}

code {
  padding: 2px 4px;
  font-size: 90%;
  color: #c7254e;
  white-space: nowrap;
  background-color: #f9f2f4;
  border-radius: 0.5em;
}

pre {
  display: block;
  padding: 10.5px;
  margin: 0 0 11px;
  font-size: 15px;
  line-height: 1.428571429;
  color: #333333;
  word-break: break-all;
  word-wrap: break-word;
  background-color: #f5f5f5;
  border: 1px solid #cccccc;
  border-radius: 0.5em;
}

pre code {
  padding: 0;
  font-size: inherit;
  color: inherit;
  white-space: pre-wrap;
  background-color: transparent;
  border: 0;
}

.pre-scrollable {
  max-height: 340px;
  overflow-y: scroll;
}

.container {
  padding-right: 15px;
  padding-left: 15px;
  margin-right: auto;
  margin-left: auto;
}

.container:before,
.container:after {
  display: table;
  content: " ";
}

.container:after {
  clear: both;
}

.container:before,
.container:after {
  display: table;
  content: " ";
}

.container:after {
  clear: both;
}

.row {
  margin-right: -15px;
  margin-left: -15px;
}

.row:before,
.row:after {
  display: table;
  content: " ";
}

.row:after {
  clear: both;
}

.row:before,
.row:after {
  display: table;
  content: " ";
}

.row:after {
  clear: both;
}

.col-xs-1,
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-5,
.col-xs-6,
.col-xs-7,
.col-xs-8,
.col-xs-9,
.col-xs-10,
.col-xs-11,
.col-xs-12,
.col-sm-1,
.col-sm-2,
.col-sm-3,
.col-sm-4,
.col-sm-5,
.col-sm-6,
.col-sm-7,
.col-sm-8,
.col-sm-9,
.col-sm-10,
.col-sm-11,
.col-sm-12,
.col-md-1,
.col-md-2,
.col-md-3,
.col-md-4,
.col-md-5,
.col-md-6,
.col-md-7,
.col-md-8,
.col-md-9,
.col-md-10,
.col-md-11,
.col-md-12,
.col-lg-1,
.col-lg-2,
.col-lg-3,
.col-lg-4,
.col-lg-5,
.col-lg-6,
.col-lg-7,
.col-lg-8,
.col-lg-9,
.col-lg-10,
.col-lg-11,
.col-lg-12 {
  position: relative;
  min-height: 1px;
  padding-right: 15px;
  padding-left: 15px;
}

.col-xs-1,
.col-xs-2,
.col-xs-3,
.col-xs-4,
.col-xs-5,
.col-xs-6,
.col-xs-7,
.col-xs-8,
.col-xs-9,
.col-xs-10,
.col-xs-11 {
  float: left;
}

.col-xs-1 {
  width: 8.333333333333332%;
}

.col-xs-2 {
  width: 16.666666666666664%;
}

.col-xs-3 {
  width: 25%;
}

.col-xs-4 {
  width: 33.33333333333333%;
}

.col-xs-5 {
  width: 41.66666666666667%;
}

.col-xs-6 {
  width: 50%;
}

.col-xs-7 {
  width: 58.333333333333336%;
}

.col-xs-8 {
  width: 66.66666666666666%;
}

.col-xs-9 {
  width: 75%;
}

.col-xs-10 {
  width: 83.33333333333334%;
}

.col-xs-11 {
  width: 91.66666666666666%;
}

.col-xs-12 {
  width: 100%;
}

@media (min-width: 768px) {
  .container {
    max-width: 750px;
  }
  .col-sm-1,
  .col-sm-2,
  .col-sm-3,
  .col-sm-4,
  .col-sm-5,
  .col-sm-6,
  .col-sm-7,
  .col-sm-8,
  .col-sm-9,
  .col-sm-10,
  .col-sm-11 {
    float: left;
  }
  .col-sm-1 {
    width: 8.333333333333332%;
  }
  .col-sm-2 {
    width: 16.666666666666664%;
  }
  .col-sm-3 {
    width: 25%;
  }
  .col-sm-4 {
    width: 33.33333333333333%;
  }
  .col-sm-5 {
    width: 41.66666666666667%;
  }
  .col-sm-6 {
    width: 50%;
  }
  .col-sm-7 {
    width: 58.333333333333336%;
  }
  .col-sm-8 {
    width: 66.66666666666666%;
  }
  .col-sm-9 {
    width: 75%;
  }
  .col-sm-10 {
    width: 83.33333333333334%;
  }
  .col-sm-11 {
    width: 91.66666666666666%;
  }
  .col-sm-12 {
    width: 100%;
  }
  .col-sm-push-1 {
    left: 8.333333333333332%;
  }
  .col-sm-push-2 {
    left: 16.666666666666664%;
  }
  .col-sm-push-3 {
    left: 25%;
  }
  .col-sm-push-4 {
    left: 33.33333333333333%;
  }
  .col-sm-push-5 {
    left: 41.66666666666667%;
  }
  .col-sm-push-6 {
    left: 50%;
  }
  .col-sm-push-7 {
    left: 58.333333333333336%;
  }
  .col-sm-push-8 {
    left: 66.66666666666666%;
  }
  .col-sm-push-9 {
    left: 75%;
  }
  .col-sm-push-10 {
    left: 83.33333333333334%;
  }
  .col-sm-push-11 {
    left: 91.66666666666666%;
  }
  .col-sm-pull-1 {
    right: 8.333333333333332%;
  }
  .col-sm-pull-2 {
    right: 16.666666666666664%;
  }
  .col-sm-pull-3 {
    right: 25%;
  }
  .col-sm-pull-4 {
    right: 33.33333333333333%;
  }
  .col-sm-pull-5 {
    right: 41.66666666666667%;
  }
  .col-sm-pull-6 {
    right: 50%;
  }
  .col-sm-pull-7 {
    right: 58.333333333333336%;
  }
  .col-sm-pull-8 {
    right: 66.66666666666666%;
  }
  .col-sm-pull-9 {
    right: 75%;
  }
  .col-sm-pull-10 {
    right: 83.33333333333334%;
  }
  .col-sm-pull-11 {
    right: 91.66666666666666%;
  }
  .col-sm-offset-1 {
    margin-left: 8.333333333333332%;
  }
  .col-sm-offset-2 {
    margin-left: 16.666666666666664%;
  }
  .col-sm-offset-3 {
    margin-left: 25%;
  }
  .col-sm-offset-4 {
    margin-left: 33.33333333333333%;
  }
  .col-sm-offset-5 {
    margin-left: 41.66666666666667%;
  }
  .col-sm-offset-6 {
    margin-left: 50%;
  }
  .col-sm-offset-7 {
    margin-left: 58.333333333333336%;
  }
  .col-sm-offset-8 {
    margin-left: 66.66666666666666%;
  }
  .col-sm-offset-9 {
    margin-left: 75%;
  }
  .col-sm-offset-10 {
    margin-left: 83.33333333333334%;
  }
  .col-sm-offset-11 {
    margin-left: 91.66666666666666%;
  }
}

@media (min-width: 992px) {
  .container {
    max-width: 970px;
  }
  .col-md-1,
  .col-md-2,
  .col-md-3,
  .col-md-4,
  .col-md-5,
  .col-md-6,
  .col-md-7,
  .col-md-8,
  .col-md-9,
  .col-md-10,
  .col-md-11 {
    float: left;
  }
  .col-md-1 {
    width: 8.333333333333332%;
  }
  .col-md-2 {
    width: 16.666666666666664%;
  }
  .col-md-3 {
    width: 25%;
  }
  .col-md-4 {
    width: 33.33333333333333%;
  }
  .col-md-5 {
    width: 41.66666666666667%;
  }
  .col-md-6 {
    width: 50%;
  }
  .col-md-7 {
    width: 58.333333333333336%;
  }
  .col-md-8 {
    width: 66.66666666666666%;
  }
  .col-md-9 {
    width: 75%;
  }
  .col-md-10 {
    width: 83.33333333333334%;
  }
  .col-md-11 {
    width: 91.66666666666666%;
  }
  .col-md-12 {
    width: 100%;
  }
  .col-md-push-0 {
    left: auto;
  }
  .col-md-push-1 {
    left: 8.333333333333332%;
  }
  .col-md-push-2 {
    left: 16.666666666666664%;
  }
  .col-md-push-3 {
    left: 25%;
  }
  .col-md-push-4 {
    left: 33.33333333333333%;
  }
  .col-md-push-5 {
    left: 41.66666666666667%;
  }
  .col-md-push-6 {
    left: 50%;
  }
  .col-md-push-7 {
    left: 58.333333333333336%;
  }
  .col-md-push-8 {
    left: 66.66666666666666%;
  }
  .col-md-push-9 {
    left: 75%;
  }
  .col-md-push-10 {
    left: 83.33333333333334%;
  }
  .col-md-push-11 {
    left: 91.66666666666666%;
  }
  .col-md-pull-0 {
    right: auto;
  }
  .col-md-pull-1 {
    right: 8.333333333333332%;
  }
  .col-md-pull-2 {
    right: 16.666666666666664%;
  }
  .col-md-pull-3 {
    right: 25%;
  }
  .col-md-pull-4 {
    right: 33.33333333333333%;
  }
  .col-md-pull-5 {
    right: 41.66666666666667%;
  }
  .col-md-pull-6 {
    right: 50%;
  }
  .col-md-pull-7 {
    right: 58.333333333333336%;
  }
  .col-md-pull-8 {
    right: 66.66666666666666%;
  }
  .col-md-pull-9 {
    right: 75%;
  }
  .col-md-pull-10 {
    right: 83.33333333333334%;
  }
  .col-md-pull-11 {
    right: 91.66666666666666%;
  }
  .col-md-offset-0 {
    margin-left: 0;
  }
  .col-md-offset-1 {
    margin-left: 8.333333333333332%;
  }
  .col-md-offset-2 {
    margin-left: 16.666666666666664%;
  }
  .col-md-offset-3 {
    margin-left: 25%;
  }
  .col-md-offset-4 {
    margin-left: 33.33333333333333%;
  }
  .col-md-offset-5 {
    margin-left: 41.66666666666667%;
  }
  .col-md-offset-6 {
    margin-left: 50%;
  }
  .col-md-offset-7 {
    margin-left: 58.333333333333336%;
  }
  .col-md-offset-8 {
    margin-left: 66.66666666666666%;
  }
  .col-md-offset-9 {
    margin-left: 75%;
  }
  .col-md-offset-10 {
    margin-left: 83.33333333333334%;
  }
  .col-md-offset-11 {
    margin-left: 91.66666666666666%;
  }
}

@media (min-width: 1200px) {
  .container {
    max-width: 1170px;
  }
  .col-lg-1,
  .col-lg-2,
  .col-lg-3,
  .col-lg-4,
  .col-lg-5,
  .col-lg-6,
  .col-lg-7,
  .col-lg-8,
  .col-lg-9,
  .col-lg-10,
  .col-lg-11 {
    float: left;
  }
  .col-lg-1 {
    width: 8.333333333333332%;
  }
  .col-lg-2 {
    width: 16.666666666666664%;
  }
  .col-lg-3 {
    width: 25%;
  }
  .col-lg-4 {
    width: 33.33333333333333%;
  }
  .col-lg-5 {
    width: 41.66666666666667%;
  }
  .col-lg-6 {
    width: 50%;
  }
  .col-lg-7 {
    width: 58.333333333333336%;
  }
  .col-lg-8 {
    width: 66.66666666666666%;
  }
  .col-lg-9 {
    width: 75%;
  }
  .col-lg-10 {
    width: 83.33333333333334%;
  }
  .col-lg-11 {
    width: 91.66666666666666%;
  }
  .col-lg-12 {
    width: 100%;
  }
  .col-lg-push-0 {
    left: auto;
  }
  .col-lg-push-1 {
    left: 8.333333333333332%;
  }
  .col-lg-push-2 {
    left: 16.666666666666664%;
  }
  .col-lg-push-3 {
    left: 25%;
  }
  .col-lg-push-4 {
    left: 33.33333333333333%;
  }
  .col-lg-push-5 {
    left: 41.66666666666667%;
  }
  .col-lg-push-6 {
    left: 50%;
  }
  .col-lg-push-7 {
    left: 58.333333333333336%;
  }
  .col-lg-push-8 {
    left: 66.66666666666666%;
  }
  .col-lg-push-9 {
    left: 75%;
  }
  .col-lg-push-10 {
    left: 83.33333333333334%;
  }
  .col-lg-push-11 {
    left: 91.66666666666666%;
  }
  .col-lg-pull-0 {
    right: auto;
  }
  .col-lg-pull-1 {
    right: 8.333333333333332%;
  }
  .col-lg-pull-2 {
    right: 16.666666666666664%;
  }
  .col-lg-pull-3 {
    right: 25%;
  }
  .col-lg-pull-4 {
    right: 33.33333333333333%;
  }
  .col-lg-pull-5 {
    right: 41.66666666666667%;
  }
  .col-lg-pull-6 {
    right: 50%;
  }
  .col-lg-pull-7 {
    right: 58.333333333333336%;
  }
  .col-lg-pull-8 {
    right: 66.66666666666666%;
  }
  .col-lg-pull-9 {
    right: 75%;
  }
  .col-lg-pull-10 {
    right: 83.33333333333334%;
  }
  .col-lg-pull-11 {
    right: 91.66666666666666%;
  }
  .col-lg-offset-0 {
    margin-left: 0;
  }
  .col-lg-offset-1 {
    margin-left: 8.333333333333332%;
  }
  .col-lg-offset-2 {
    margin-left: 16.666666666666664%;
  }
  .col-lg-offset-3 {
    margin-left: 25%;
  }
  .col-lg-offset-4 {
    margin-left: 33.33333333333333%;
  }
  .col-lg-offset-5 {
    margin-left: 41.66666666666667%;
  }
  .col-lg-offset-6 {
    margin-left: 50%;
  }
  .col-lg-offset-7 {
    margin-left: 58.333333333333336%;
  }
  .col-lg-offset-8 {
    margin-left: 66.66666666666666%;
  }
  .col-lg-offset-9 {
    margin-left: 75%;
  }
  .col-lg-offset-10 {
    margin-left: 83.33333333333334%;
  }
  .col-lg-offset-11 {
    margin-left: 91.66666666666666%;
  }
}

table {
  max-width: 100%;
  background-color: transparent;
}

th {
  text-align: left;
}

.table {
  width: 100%;
  margin-bottom: 22px;
}

.table > thead > tr > th,
.table > tbody > tr > th,
.table > tfoot > tr > th,
.table > thead > tr > td,
.table > tbody > tr > td,
.table > tfoot > tr > td {
  padding: 8px;
  line-height: 1.428571429;
  vertical-align: top;
  border-top: 1px solid #dddddd;
}

.table > thead > tr > th {
  vertical-align: bottom;
  border-bottom: 2px solid #dddddd;
}

.table > caption + thead > tr:first-child > th,
.table > colgroup + thead > tr:first-child > th,
.table > thead:first-child > tr:first-child > th,
.table > caption + thead > tr:first-child > td,
.table > colgroup + thead > tr:first-child > td,
.table > thead:first-child > tr:first-child > td {
  border-top: 0;
}

.table > tbody + tbody {
  border-top: 2px solid #dddddd;
}

.table .table {
  background-color: #ffffff;
}

.table-condensed > thead > tr > th,
.table-condensed > tbody > tr > th,
.table-condensed > tfoot > tr > th,
.table-condensed > thead > tr > td,
.table-condensed > tbody > tr > td,
.table-condensed > tfoot > tr > td {
  padding: 5px;
}

.table-bordered {
  border: 1px solid #dddddd;
}

.table-bordered > thead > tr > th,
.table-bordered > tbody > tr > th,
.table-bordered > tfoot > tr > th,
.table-bordered > thead > tr > td,
.table-bordered > tbody > tr > td,
.table-bordered > tfoot > tr > td {
  border: 1px solid #dddddd;
}

.table-bordered > thead > tr > th,
.table-bordered > thead > tr > td {
  border-bottom-width: 2px;
}

.table-striped > tbody > tr:nth-child(odd) > td,
.table-striped > tbody > tr:nth-child(odd) > th {
  background-color: #f9f9f9;
}

.table-hover > tbody > tr:hover > td,
.table-hover > tbody > tr:hover > th {
  background-color: #f5f5f5;
}

table col[class*="col-"] {
  display: table-column;
  float: none;
}

table td[class*="col-"],
table th[class*="col-"] {
  display: table-cell;
  float: none;
}

.table > thead > tr > td.active,
.table > tbody > tr > td.active,
.table > tfoot > tr > td.active,
.table > thead > tr > th.active,
.table > tbody > tr > th.active,
.table > tfoot > tr > th.active,
.table > thead > tr.active > td,
.table > tbody > tr.active > td,
.table > tfoot > tr.active > td,
.table > thead > tr.active > th,
.table > tbody > tr.active > th,
.table > tfoot > tr.active > th {
  background-color: #f5f5f5;
}

.table > thead > tr > td.success,
.table > tbody > tr > td.success,
.table > tfoot > tr > td.success,
.table > thead > tr > th.success,
.table > tbody > tr > th.success,
.table > tfoot > tr > th.success,
.table > thead > tr.success > td,
.table > tbody > tr.success > td,
.table > tfoot > tr.success > td,
.table > thead > tr.success > th,
.table > tbody > tr.success > th,
.table > tfoot > tr.success > th {
  background-color: #dff0d8;
  border-color: #d6e9c6;
}

.table-hover > tbody > tr > td.success:hover,
.table-hover > tbody > tr > th.success:hover,
.table-hover > tbody > tr.success:hover > td,
.table-hover > tbody > tr.success:hover > th {
  background-color: #d0e9c6;
  border-color: #c9e2b3;
}

.table > thead > tr > td.danger,
.table > tbody > tr > td.danger,
.table > tfoot > tr > td.danger,
.table > thead > tr > th.danger,
.table > tbody > tr > th.danger,
.table > tfoot > tr > th.danger,
.table > thead > tr.danger > td,
.table > tbody > tr.danger > td,
.table > tfoot > tr.danger > td,
.table > thead > tr.danger > th,
.table > tbody > tr.danger > th,
.table > tfoot > tr.danger > th {
  background-color: #f2dede;
  border-color: #ebccd1;
}

.table-hover > tbody > tr > td.danger:hover,
.table-hover > tbody > tr > th.danger:hover,
.table-hover > tbody > tr.danger:hover > td,
.table-hover > tbody > tr.danger:hover > th {
  background-color: #ebcccc;
  border-color: #e4b9c0;
}

.table > thead > tr > td.warning,
.table > tbody > tr > td.warning,
.table > tfoot > tr > td.warning,
.table > thead > tr > th.warning,
.table > tbody > tr > th.warning,
.table > tfoot > tr > th.warning,
.table > thead > tr.warning > td,
.table > tbody > tr.warning > td,
.table > tfoot > tr.warning > td,
.table > thead > tr.warning > th,
.table > tbody > tr.warning > th,
.table > tfoot > tr.warning > th {
  background-color: #fcf8e3;
  border-color: #faebcc;
}

.table-hover > tbody > tr > td.warning:hover,
.table-hover > tbody > tr > th.warning:hover,
.table-hover > tbody > tr.warning:hover > td,
.table-hover > tbody > tr.warning:hover > th {
  background-color: #faf2cc;
  border-color: #f7e1b5;
}

@media (max-width: 768px) {
  .table-responsive {
    width: 100%;
    margin-bottom: 15px;
    overflow-x: scroll;
    overflow-y: hidden;
    border: 1px solid #dddddd;
    -ms-overflow-style: -ms-autohiding-scrollbar;
    -webkit-overflow-scrolling: touch;
  }
  .table-responsive > .table {
    margin-bottom: 0;
  }
  .table-responsive > .table > thead > tr > th,
  .table-responsive > .table > tbody > tr > th,
  .table-responsive > .table > tfoot > tr > th,
  .table-responsive > .table > thead > tr > td,
  .table-responsive > .table > tbody > tr > td,
  .table-responsive > .table > tfoot > tr > td {
    white-space: nowrap;
  }
  .table-responsive > .table-bordered {
    border: 0;
  }
  .table-responsive > .table-bordered > thead > tr > th:first-child,
  .table-responsive > .table-bordered > tbody > tr > th:first-child,
  .table-responsive > .table-bordered > tfoot > tr > th:first-child,
  .table-responsive > .table-bordered > thead > tr > td:first-child,
  .table-responsive > .table-bordered > tbody > tr > td:first-child,
  .table-responsive > .table-bordered > tfoot > tr > td:first-child {
    border-left: 0;
  }
  .table-responsive > .table-bordered > thead > tr > th:last-child,
  .table-responsive > .table-bordered > tbody > tr > th:last-child,
  .table-responsive > .table-bordered > tfoot > tr > th:last-child,
  .table-responsive > .table-bordered > thead > tr > td:last-child,
  .table-responsive > .table-bordered > tbody > tr > td:last-child,
  .table-responsive > .table-bordered > tfoot > tr > td:last-child {
    border-right: 0;
  }
  .table-responsive > .table-bordered > tbody > tr:last-child > th,
  .table-responsive > .table-bordered > tfoot > tr:last-child > th,
  .table-responsive > .table-bordered > tbody > tr:last-child > td,
  .table-responsive > .table-bordered > tfoot > tr:last-child > td {
    border-bottom: 0;
  }
}

fieldset {
  padding: 0;
  margin: 0;
  border: 0;
}

legend {
  display: block;
  width: 100%;
  padding: 0;
  margin-bottom: 22px;
  font-size: 24px;
  line-height: inherit;
  color: #333333;
  border: 0;
  border-bottom: 1px solid #e5e5e5;
}

label {
  display: inline-block;
  margin-bottom: 5px;
  font-weight: bold;
}

input[type="search"] {
  -webkit-box-sizing: border-box;
     -moz-box-sizing: border-box;
          box-sizing: border-box;
}

input[type="radio"],
input[type="checkbox"] {
  margin: 4px 0 0;
  margin-top: 1px \9;
  /* IE8-9 */

  line-height: normal;
}

input[type="file"] {
  display: block;
}

select[multiple],
select[size] {
  height: auto;
}

select optgroup {
  font-family: inherit;
  font-size: inherit;
  font-style: inherit;
}

input[type="file"]:focus,
input[type="radio"]:focus,
input[type="checkbox"]:focus {
  outline: thin dotted #333;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

input[type="number"]::-webkit-outer-spin-button,
input[type="number"]::-webkit-inner-spin-button {
  height: auto;
}

output {
  display: block;
  padding-top: 7px;
  font-size: 16px;
  line-height: 1.428571429;
  color: #555555;
  vertical-align: middle;
}

.form-control:-moz-placeholder {
  color: #999999;
}

.form-control::-moz-placeholder {
  color: #999999;
}

.form-control:-ms-input-placeholder {
  color: #999999;
}

.form-control::-webkit-input-placeholder {
  color: #999999;
}

.form-control {
  display: block;
  width: 100%;
  height: 36px;
  padding: 6px 12px;
  font-size: 16px;
  line-height: 1.428571429;
  color: #555555;
  vertical-align: middle;
  background-color: #ffffff;
  background-image: none;
  border: 1px solid #979ca1;
  border-radius: 0;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  -webkit-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
          transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s;
}

.form-control:focus {
  border-color: #83cae8;
  outline: 0;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(131, 202, 232, 0.6);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(131, 202, 232, 0.6);
}

.form-control[disabled],
.form-control[readonly],
fieldset[disabled] .form-control {
  cursor: not-allowed;
  background-color: #eeeeee;
}

textarea.form-control {
  height: auto;
}

.form-group {
  margin-bottom: 15px;
}

.radio,
.checkbox {
  display: block;
  min-height: 22px;
  padding-left: 20px;
  margin-top: 10px;
  margin-bottom: 10px;
  vertical-align: middle;
}

.radio label,
.checkbox label {
  display: inline;
  margin-bottom: 0;
  font-weight: normal;
  cursor: pointer;
}

.radio input[type="radio"],
.radio-inline input[type="radio"],
.checkbox input[type="checkbox"],
.checkbox-inline input[type="checkbox"] {
  float: left;
  margin-left: -20px;
}

.radio + .radio,
.checkbox + .checkbox {
  margin-top: -5px;
}

.radio-inline,
.checkbox-inline {
  display: inline-block;
  padding-left: 20px;
  margin-bottom: 0;
  font-weight: normal;
  vertical-align: middle;
  cursor: pointer;
}

.radio-inline + .radio-inline,
.checkbox-inline + .checkbox-inline {
  margin-top: 0;
  margin-left: 10px;
}

input[type="radio"][disabled],
input[type="checkbox"][disabled],
.radio[disabled],
.radio-inline[disabled],
.checkbox[disabled],
.checkbox-inline[disabled],
fieldset[disabled] input[type="radio"],
fieldset[disabled] input[type="checkbox"],
fieldset[disabled] .radio,
fieldset[disabled] .radio-inline,
fieldset[disabled] .checkbox,
fieldset[disabled] .checkbox-inline {
  cursor: not-allowed;
}

.input-sm {
  height: 33px;
  padding: 5px 10px;
  font-size: 14px;
  line-height: 1.5;
  border-radius: 0.5em;
}

select.input-sm {
  height: 33px;
  line-height: 33px;
}

textarea.input-sm {
  height: auto;
}

.input-lg {
  height: 48px;
  padding: 10px 16px;
  font-size: 20px;
  line-height: 1.33;
  border-radius: 0.5em;
}

select.input-lg {
  height: 48px;
  line-height: 48px;
}

textarea.input-lg {
  height: auto;
}

.has-warning .help-block,
.has-warning .control-label {
  color: #c09853;
}

.has-warning .form-control {
  border-color: #c09853;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
}

.has-warning .form-control:focus {
  border-color: #a47e3c;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #dbc59e;
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #dbc59e;
}

.has-warning .input-group-addon {
  color: #c09853;
  background-color: #fcf8e3;
  border-color: #c09853;
}

.has-error .help-block,
.has-error .control-label {
  color: #b94a48;
}

.has-error .form-control {
  border-color: #b94a48;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
}

.has-error .form-control:focus {
  border-color: #953b39;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #d59392;
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #d59392;
}

.has-error .input-group-addon {
  color: #b94a48;
  background-color: #f2dede;
  border-color: #b94a48;
}

.has-success .help-block,
.has-success .control-label {
  color: #468847;
}

.has-success .form-control {
  border-color: #468847;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
}

.has-success .form-control:focus {
  border-color: #356635;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #7aba7b;
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #7aba7b;
}

.has-success .input-group-addon {
  color: #468847;
  background-color: #dff0d8;
  border-color: #468847;
}

.form-control-static {
  padding-top: 7px;
  margin-bottom: 0;
}

.help-block {
  display: block;
  margin-top: 5px;
  margin-bottom: 10px;
  color: #737373;
}

@media (min-width: 768px) {
  .form-inline .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle;
  }
  .form-inline .form-control {
    display: inline-block;
  }
  .form-inline .radio,
  .form-inline .checkbox {
    display: inline-block;
    padding-left: 0;
    margin-top: 0;
    margin-bottom: 0;
  }
  .form-inline .radio input[type="radio"],
  .form-inline .checkbox input[type="checkbox"] {
    float: none;
    margin-left: 0;
  }
}

.form-horizontal .control-label,
.form-horizontal .radio,
.form-horizontal .checkbox,
.form-horizontal .radio-inline,
.form-horizontal .checkbox-inline {
  padding-top: 7px;
  margin-top: 0;
  margin-bottom: 0;
}

.form-horizontal .form-group {
  margin-right: -15px;
  margin-left: -15px;
}

.form-horizontal .form-group:before,
.form-horizontal .form-group:after {
  display: table;
  content: " ";
}

.form-horizontal .form-group:after {
  clear: both;
}

.form-horizontal .form-group:before,
.form-horizontal .form-group:after {
  display: table;
  content: " ";
}

.form-horizontal .form-group:after {
  clear: both;
}

@media (min-width: 768px) {
  .form-horizontal .control-label {
    text-align: right;
  }
}

.btn {
  display: inline-block;
  padding: 6px 12px;
  margin-bottom: 0;
  font-size: 16px;
  font-weight: normal;
  line-height: 1.428571429;
  text-align: center;
  white-space: nowrap;
  vertical-align: middle;
  cursor: pointer;
  background-image: none;
  border: 1px solid transparent;
  border-radius: 0.5em;
  -webkit-user-select: none;
     -moz-user-select: none;
      -ms-user-select: none;
       -o-user-select: none;
          user-select: none;
}

.btn:focus {
  outline: thin dotted #333;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px;
}

.btn:hover,
.btn:focus {
  color: #2f4fa2;
  text-decoration: none;
}

.btn:active,
.btn.active {
  background-image: none;
  outline: 0;
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
          box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
}

.btn.disabled,
.btn[disabled],
fieldset[disabled] .btn {
  pointer-events: none;
  cursor: not-allowed;
  opacity: 0.65;
  filter: alpha(opacity=65);
  -webkit-box-shadow: none;
          box-shadow: none;
}

.btn-default {
  color: #2f4fa2;
  background-color: #ffffff;
  border-color: rgba(47, 79, 162, 0.8);
}

.btn-default:hover,
.btn-default:focus,
.btn-default:active,
.btn-default.active,
.open .dropdown-toggle.btn-default {
  color: #2f4fa2;
  background-color: #ebebeb;
  border-color: rgba(33, 56, 115, 0.8);
}

.btn-default:active,
.btn-default.active,
.open .dropdown-toggle.btn-default {
  background-image: none;
}

.btn-default.disabled,
.btn-default[disabled],
fieldset[disabled] .btn-default,
.btn-default.disabled:hover,
.btn-default[disabled]:hover,
fieldset[disabled] .btn-default:hover,
.btn-default.disabled:focus,
.btn-default[disabled]:focus,
fieldset[disabled] .btn-default:focus,
.btn-default.disabled:active,
.btn-default[disabled]:active,
fieldset[disabled] .btn-default:active,
.btn-default.disabled.active,
.btn-default[disabled].active,
fieldset[disabled] .btn-default.active {
  background-color: #ffffff;
  border-color: rgba(47, 79, 162, 0.8);
}

.btn-primary {
  color: #ffffff;
  background-color: #2f4fa2;
  border-color: #29458e;
}

.btn-primary:hover,
.btn-primary:focus,
.btn-primary:active,
.btn-primary.active,
.open .dropdown-toggle.btn-primary {
  color: #ffffff;
  background-color: #264082;
  border-color: #1c2e5f;
}

.btn-primary:active,
.btn-primary.active,
.open .dropdown-toggle.btn-primary {
  background-image: none;
}

.btn-primary.disabled,
.btn-primary[disabled],
fieldset[disabled] .btn-primary,
.btn-primary.disabled:hover,
.btn-primary[disabled]:hover,
fieldset[disabled] .btn-primary:hover,
.btn-primary.disabled:focus,
.btn-primary[disabled]:focus,
fieldset[disabled] .btn-primary:focus,
.btn-primary.disabled:active,
.btn-primary[disabled]:active,
fieldset[disabled] .btn-primary:active,
.btn-primary.disabled.active,
.btn-primary[disabled].active,
fieldset[disabled] .btn-primary.active {
  background-color: #2f4fa2;
  border-color: #29458e;
}

.btn-warning {
  color: #ffffff;
  background-color: #f0ad4e;
  border-color: #eea236;
}

.btn-warning:hover,
.btn-warning:focus,
.btn-warning:active,
.btn-warning.active,
.open .dropdown-toggle.btn-warning {
  color: #ffffff;
  background-color: #ed9c28;
  border-color: #d58512;
}

.btn-warning:active,
.btn-warning.active,
.open .dropdown-toggle.btn-warning {
  background-image: none;
}

.btn-warning.disabled,
.btn-warning[disabled],
fieldset[disabled] .btn-warning,
.btn-warning.disabled:hover,
.btn-warning[disabled]:hover,
fieldset[disabled] .btn-warning:hover,
.btn-warning.disabled:focus,
.btn-warning[disabled]:focus,
fieldset[disabled] .btn-warning:focus,
.btn-warning.disabled:active,
.btn-warning[disabled]:active,
fieldset[disabled] .btn-warning:active,
.btn-warning.disabled.active,
.btn-warning[disabled].active,
fieldset[disabled] .btn-warning.active {
  background-color: #f0ad4e;
  border-color: #eea236;
}

.btn-danger {
  color: #ffffff;
  background-color: #d9534f;
  border-color: #d43f3a;
}

.btn-danger:hover,
.btn-danger:focus,
.btn-danger:active,
.btn-danger.active,
.open .dropdown-toggle.btn-danger {
  color: #ffffff;
  background-color: #d2322d;
  border-color: #ac2925;
}

.btn-danger:active,
.btn-danger.active,
.open .dropdown-toggle.btn-danger {
  background-image: none;
}

.btn-danger.disabled,
.btn-danger[disabled],
fieldset[disabled] .btn-danger,
.btn-danger.disabled:hover,
.btn-danger[disabled]:hover,
fieldset[disabled] .btn-danger:hover,
.btn-danger.disabled:focus,
.btn-danger[disabled]:focus,
fieldset[disabled] .btn-danger:focus,
.btn-danger.disabled:active,
.btn-danger[disabled]:active,
fieldset[disabled] .btn-danger:active,
.btn-danger.disabled.active,
.btn-danger[disabled].active,
fieldset[disabled] .btn-danger.active {
  background-color: #d9534f;
  border-color: #d43f3a;
}

.btn-success {
  color: #ffffff;
  background-color: #5cb85c;
  border-color: #4cae4c;
}

.btn-success:hover,
.btn-success:focus,
.btn-success:active,
.btn-success.active,
.open .dropdown-toggle.btn-success {
  color: #ffffff;
  background-color: #47a447;
  border-color: #398439;
}

.btn-success:active,
.btn-success.active,
.open .dropdown-toggle.btn-success {
  background-image: none;
}

.btn-success.disabled,
.btn-success[disabled],
fieldset[disabled] .btn-success,
.btn-success.disabled:hover,
.btn-success[disabled]:hover,
fieldset[disabled] .btn-success:hover,
.btn-success.disabled:focus,
.btn-success[disabled]:focus,
fieldset[disabled] .btn-success:focus,
.btn-success.disabled:active,
.btn-success[disabled]:active,
fieldset[disabled] .btn-success:active,
.btn-success.disabled.active,
.btn-success[disabled].active,
fieldset[disabled] .btn-success.active {
  background-color: #5cb85c;
  border-color: #4cae4c;
}

.btn-info {
  color: #ffffff;
  background-color: #5bc0de;
  border-color: #46b8da;
}

.btn-info:hover,
.btn-info:focus,
.btn-info:active,
.btn-info.active,
.open .dropdown-toggle.btn-info {
  color: #ffffff;
  background-color: #39b3d7;
  border-color: #269abc;
}

.btn-info:active,
.btn-info.active,
.open .dropdown-toggle.btn-info {
  background-image: none;
}

.btn-info.disabled,
.btn-info[disabled],
fieldset[disabled] .btn-info,
.btn-info.disabled:hover,
.btn-info[disabled]:hover,
fieldset[disabled] .btn-info:hover,
.btn-info.disabled:focus,
.btn-info[disabled]:focus,
fieldset[disabled] .btn-info:focus,
.btn-info.disabled:active,
.btn-info[disabled]:active,
fieldset[disabled] .btn-info:active,
.btn-info.disabled.active,
.btn-info[disabled].active,
fieldset[disabled] .btn-info.active {
  background-color: #5bc0de;
  border-color: #46b8da;
}

.btn-link {
  font-weight: normal;
  color: #2f4fa2;
  cursor: pointer;
  border-radius: 0;
}

.btn-link,
.btn-link:active,
.btn-link[disabled],
fieldset[disabled] .btn-link {
  background-color: transparent;
  -webkit-box-shadow: none;
          box-shadow: none;
}

.btn-link,
.btn-link:hover,
.btn-link:focus,
.btn-link:active {
  border-color: transparent;
}

.btn-link:hover,
.btn-link:focus {
  color: #1e3267;
  text-decoration: underline;
  background-color: transparent;
}

.btn-link[disabled]:hover,
fieldset[disabled] .btn-link:hover,
.btn-link[disabled]:focus,
fieldset[disabled] .btn-link:focus {
  color: #999999;
  text-decoration: none;
}

.btn-lg {
  padding: 10px 16px;
  font-size: 20px;
  line-height: 1.33;
  border-radius: 0.5em;
}

.btn-sm,
.btn-xs {
  padding: 5px 10px;
  font-size: 14px;
  line-height: 1.5;
  border-radius: 0.5em;
}

.btn-xs {
  padding: 1px 5px;
}

.btn-block {
  display: block;
  width: 100%;
  padding-right: 0;
  padding-left: 0;
}

.btn-block + .btn-block {
  margin-top: 5px;
}

input[type="submit"].btn-block,
input[type="reset"].btn-block,
input[type="button"].btn-block {
  width: 100%;
}

@font-face {
  font-family: 'TS';
  font-style: normal;
  font-weight: normal;
  src: url('../fonts/TS.eot');
  src: url('../fonts/TS.eot?#iefix') format('embedded-opentype'), url('../fonts/TS.woff') format('woff'), url('../fonts/TS.ttf') format('truetype'), url('../fonts/TS.svg#TS') format('svg');
}

@font-face {
  font-family: 'TS';
  font-style: normal;
  font-weight: normal;
  src: url(data:application/font-woff;charset=utf-8;base64,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) format('woff'), url(data:application/x-font-ttf;charset=utf-8;base64,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MDIHdW5pRTAwMwd1bmlFMDA0B3VuaUUwMDUHdW5pRTAwNwd1bmlFMDAxB3VuaUUwNDQHdW5pRTA0NQd1bmlFMDQ2B3VuaUUwNDcHdW5pRjE0NAd1bmlGMEM0B3VuaUYwNzUHdW5pRjA4Ngd1bmlGMDBBB3VuaUYwMEIHdW5pRjBDOQd1bmlGMDA1B3VuaUYwMDYHdW5pRjAwQwd1bmlGMDBEB3VuaUYwMTQHdW5pRTAwOAd1bmlFMDA2B3VuaUYwMjQHdW5pRjA0MAd1bmlGMDk2B3VuaUYwODIHdW5pRjA4Qwd1bmlGMDk5B3VuaUYwNzMHdW5pRTAwOQd1bmlGMTQ2B3VuaUYwRkUHdW5pRjAzRAd1bmlFMDBBB3VuaUUwMDAHdW5pRjAyMgd1bmlGMDE2B3VuaUYwRUEHdW5pRjBENwd1bmlGMEQ4B3VuaUYwRDkHdW5pRjEyOQd1bmlGMDNFB3VuaUYwMjUHdW5pRjEwQwd1bmlGMTExB3VuaUYxNUQHdW5pRjE1RQd1bmlGMTYyB3VuaUYxNjMHdW5pRjBBMwd1bmlGMENFB3VuaUYwN0IHdW5pRTAwQgd1bmlGMDIxB3VuaUYwNTkHdW5pRjA1Mwd1bmlGMDU0B3VuaUYwNzcHdW5pRjA3OAd1bmlGMEU0B3VuaUYwNjcHdW5pRjA2OAd1bmlGMDY5B3VuaUUwMTYHdW5pRjJGRQd1bmlGMkZGB3VuaUYzMDAHdW5pRjMwMQd1bmlGMzAyB3VuaUYzMDMHdW5pRjMwNAd1bmlGMzA1B3VuaUUwMEMHdW5pRjBEQQd1bmlGMDQ2B3VuaUUwMEQHdW5pRTAwRQAAAAAAAf//AAIAAQAAAA4AAAAYAAAAAAACAAEAAwBVAAEABAAAAAIAAAAAAAEAAAAAyYlvMQAAAADOiw4cAAAAAM6LDhw=) format('truetype');
}

/* Use the following CSS code if you want to use data attributes for inserting your icons */

[data-icon]:before {
  font-family: 'TS';
  -webkit-font-smoothing: antialiased;
  font-weight: normal;
  line-height: 1;
  text-transform: none;
  content: attr(data-icon);
  speak: none;
  font-variant: normal;
  -moz-osx-font-smoothing: grayscale;
}

/* Use the following CSS code if you want to have a class per icon */

/*
Instead of a list of all class selectors,
you can use the generic selector below, but it's slower:
[class*="icon-"] {
*/

.icon-microphone,
.icon-microphone-off,
.icon-Focus-Logo,
.icon-Reflect-Logo,
.icon-Learn-Logo,
.icon-Advance-Logo,
.icon-Classroom,
.icon-Teachscape,
.icon-Advance,
.icon-Focus,
.icon-Learn,
.icon-Reflect,
.icon-play-sign,
.icon-cut,
.icon-comment,
.icon-comments,
.icon-th,
.icon-th-list,
.icon-reorder,
.icon-star,
.icon-star-empty,
.icon-ok,
.icon-remove,
.icon-trash,
.icon-home,
.icon-Walkthrough,
.icon-lock,
.icon-pencil,
.icon-check-empty,
.icon-facebook-sign,
.icon-linkedin-sign,
.icon-twitter,
.icon-calendar,
.icon-warning,
.icon-minus-sign-alt,
.icon-plus-sign,
.icon-facetime-video,
.icon-spell-check,
.icon-download,
.icon-list-alt,
.icon-file,
.icon-paste,
.icon-caret-down,
.icon-caret-up,
.icon-caret-left,
.icon-info,
.icon-picture,
.icon-headphones,
.icon-circle-blank,
.icon-circle,
.icon-sort-by-alphabet,
.icon-sort-by-alphabet-alt,
.icon-sort-by-order,
.icon-sort-by-order-alt,
.icon-certificate,
.icon-table,
.icon-folder-close,
.icon-film,
.icon-refresh,
.icon-question-sign,
.icon-chevron-left,
.icon-chevron-right,
.icon-chevron-up,
.icon-chevron-down,
.icon-dashboard,
.icon-plus,
.icon-minus,
.icon-asterisk,
.icon-Teachscape-2,
.icon-down,
.icon-downleft,
.icon-downright,
.icon-up,
.icon-upleft,
.icon-upright,
.icon-right,
.icon-left,
.icon-file-pdf,
.icon-caret-right,
.icon-check,
.icon-check-2,
.icon-new-tab {
  font-family: 'TS';
  -webkit-font-smoothing: antialiased;
  font-style: normal;
  font-weight: normal;
  line-height: 1;
  text-transform: none;
  speak: none;
  font-variant: normal;
}

.icon-microphone:before {
  content: "\f130";
}

.icon-microphone-off:before {
  content: "\f131";
}

.icon-Focus-Logo:before {
  content: "\e002";
}

.icon-Reflect-Logo:before {
  content: "\e003";
}

.icon-Learn-Logo:before {
  content: "\e004";
}

.icon-Advance-Logo:before {
  content: "\e005";
}

.icon-Classroom:before {
  content: "\e007";
}

.icon-Teachscape:before {
  content: "\e001";
}

.icon-Advance:before {
  content: "\e044";
}

.icon-Focus:before {
  content: "\e045";
}

.icon-Learn:before {
  content: "\e046";
}

.icon-Reflect:before {
  content: "\e047";
}

.icon-play-sign:before {
  content: "\f144";
}

.icon-cut:before {
  content: "\f0c4";
}

.icon-comment:before {
  content: "\f075";
}

.icon-comments:before {
  content: "\f086";
}

.icon-th:before {
  content: "\f00a";
}

.icon-th-list:before {
  content: "\f00b";
}

.icon-reorder:before {
  content: "\f0c9";
}

.icon-star:before {
  content: "\f005";
}

.icon-star-empty:before {
  content: "\f006";
}

.icon-ok:before {
  content: "\f00c";
}

.icon-remove:before {
  content: "\f00d";
}

.icon-trash:before {
  content: "\f014";
}

.icon-home:before {
  content: "\e008";
}

.icon-Walkthrough:before {
  content: "\e006";
}

.icon-lock:before {
  content: "\f023";
}

.icon-pencil:before {
  content: "\f040";
}

.icon-check-empty:before {
  content: "\f096";
}

.icon-facebook-sign:before {
  content: "\f082";
}

.icon-linkedin-sign:before {
  content: "\f08c";
}

.icon-twitter:before {
  content: "\f099";
}

.icon-calendar:before {
  content: "\f073";
}

.icon-warning:before {
  content: "\e009";
}

.icon-minus-sign-alt:before {
  content: "\f146";
}

.icon-plus-sign:before {
  content: "\f0fe";
}

.icon-facetime-video:before {
  content: "\f03d";
}

.icon-spell-check:before {
  content: "\e00a";
}

.icon-download:before {
  content: "\e000";
}

.icon-list-alt:before {
  content: "\f022";
}

.icon-file:before {
  content: "\f016";
}

.icon-paste:before {
  content: "\f0ea";
}

.icon-caret-down:before {
  content: "\f0d7";
}

.icon-caret-up:before {
  content: "\f0d8";
}

.icon-caret-left:before {
  content: "\f0d9";
}

.icon-info:before {
  content: "\f129";
}

.icon-picture:before {
  content: "\f03e";
}

.icon-headphones:before {
  content: "\f025";
}

.icon-circle-blank:before {
  content: "\f10c";
}

.icon-circle:before {
  content: "\f111";
}

.icon-sort-by-alphabet:before {
  content: "\f15d";
}

.icon-sort-by-alphabet-alt:before {
  content: "\f15e";
}

.icon-sort-by-order:before {
  content: "\f162";
}

.icon-sort-by-order-alt:before {
  content: "\f163";
}

.icon-certificate:before {
  content: "\f0a3";
}

.icon-table:before {
  content: "\f0ce";
}

.icon-folder-close:before {
  content: "\f07b";
}

.icon-film:before {
  content: "\e00b";
}

.icon-refresh:before {
  content: "\f021";
}

.icon-question-sign:before {
  content: "\f059";
}

.icon-chevron-left:before {
  content: "\f053";
}

.icon-chevron-right:before {
  content: "\f054";
}

.icon-chevron-up:before {
  content: "\f077";
}

.icon-chevron-down:before {
  content: "\f078";
}

.icon-dashboard:before {
  content: "\f0e4";
}

.icon-plus:before {
  content: "\f067";
}

.icon-minus:before {
  content: "\f068";
}

.icon-asterisk:before {
  content: "\f069";
}

.icon-Teachscape-2:before {
  content: "\e016";
}

.icon-down:before {
  content: "\f2fe";
}

.icon-downleft:before {
  content: "\f2ff";
}

.icon-downright:before {
  content: "\f300";
}

.icon-up:before {
  content: "\f301";
}

.icon-upleft:before {
  content: "\f302";
}

.icon-upright:before {
  content: "\f303";
}

.icon-right:before {
  content: "\f304";
}

.icon-left:before {
  content: "\f305";
}

.icon-file-pdf:before {
  content: "\e00c";
}

.icon-caret-right:before {
  content: "\f0da";
}

.icon-check:before {
  content: "\f046";
}

.icon-check-2:before {
  content: "\e00d";
}

.icon-new-tab:before {
  content: "\e00e";
}

.glyph {
  float: left;
  width: 7.5em;
  padding: .75em;
  margin: .75em 1.5em .75em 0;
  font-size: 14px;
  text-align: center;
  background: #eee none repeat scroll 0 0;
  border-radius: .25em;
  box-shadow: inset 0 0 0 1px #f8f8f8, 0 0 0 1px #CCC;
}

.glyph input {
  width: 100%;
  padding: .125em;
  font-family: consolas, monospace;
  font-size: 13px;
  text-align: center;
  border: 0;
  box-shadow: 0 0 0 1px #ccc;
}

.w-main {
  width: 80%;
}

.centered {
  margin-right: auto;
  margin-left: auto;
}

.fs1 {
  font-size: 2em;
  text-align: center;
}

a,
a:visited {
  text-decoration: none;
}

a:hover,
a:focus {
  color: #000;
}

.box1 {
  display: inline-block;
  width: 15em;
  padding: .25em .5em;
  margin: .5em 1em .5em 0;
  font-size: 14px;
  background: #eee none repeat scroll 0 0;
}

.fade {
  opacity: 0;
  -webkit-transition: opacity 0.15s linear;
          transition: opacity 0.15s linear;
}

.fade.in {
  opacity: 1;
}

.collapse {
  display: none;
}

.collapse.in {
  display: block;
}

.collapsing {
  position: relative;
  height: 0;
  overflow: hidden;
  -webkit-transition: height 0.35s ease;
          transition: height 0.35s ease;
}

@font-face {
  font-family: 'Glyphicons Halflings';
  src: url('../fonts/glyphicons-halflings-regular.eot');
  src: url('../fonts/glyphicons-halflings-regular.eot?#iefix') format('embedded-opentype'), url('../fonts/glyphicons-halflings-regular.woff') format('woff'), url('../fonts/glyphicons-halflings-regular.ttf') format('truetype'), url('../fonts/glyphicons-halflings-regular.svg#glyphicons-halflingsregular') format('svg');
}

.glyphicon {
  position: relative;
  top: 1px;
  display: inline-block;
  font-family: 'Glyphicons Halflings';
  -webkit-font-smoothing: antialiased;
  font-style: normal;
  font-weight: normal;
  line-height: 1;
}

.glyphicon:empty {
  width: 1em;
}

.glyphicon-asterisk:before {
  content: "\2a";
}

.glyphicon-plus:before {
  content: "\2b";
}

.glyphicon-euro:before {
  content: "\20ac";
}

.glyphicon-minus:before {
  content: "\2212";
}

.glyphicon-cloud:before {
  content: "\2601";
}

.glyphicon-envelope:before {
  content: "\2709";
}

.glyphicon-pencil:before {
  content: "\270f";
}

.glyphicon-glass:before {
  content: "\e001";
}

.glyphicon-music:before {
  content: "\e002";
}

.glyphicon-search:before {
  content: "\e003";
}

.glyphicon-heart:before {
  content: "\e005";
}

.glyphicon-star:before {
  content: "\e006";
}

.glyphicon-star-empty:before {
  content: "\e007";
}

.glyphicon-user:before {
  content: "\e008";
}

.glyphicon-film:before {
  content: "\e009";
}

.glyphicon-th-large:before {
  content: "\e010";
}

.glyphicon-th:before {
  content: "\e011";
}

.glyphicon-th-list:before {
  content: "\e012";
}

.glyphicon-ok:before {
  content: "\e013";
}

.glyphicon-remove:before {
  content: "\e014";
}

.glyphicon-zoom-in:before {
  content: "\e015";
}

.glyphicon-zoom-out:before {
  content: "\e016";
}

.glyphicon-off:before {
  content: "\e017";
}

.glyphicon-signal:before {
  content: "\e018";
}

.glyphicon-cog:before {
  content: "\e019";
}

.glyphicon-trash:before {
  content: "\e020";
}

.glyphicon-home:before {
  content: "\e021";
}

.glyphicon-file:before {
  content: "\e022";
}

.glyphicon-time:before {
  content: "\e023";
}

.glyphicon-road:before {
  content: "\e024";
}

.glyphicon-download-alt:before {
  content: "\e025";
}

.glyphicon-download:before {
  content: "\e026";
}

.glyphicon-upload:before {
  content: "\e027";
}

.glyphicon-inbox:before {
  content: "\e028";
}

.glyphicon-play-circle:before {
  content: "\e029";
}

.glyphicon-repeat:before {
  content: "\e030";
}

.glyphicon-refresh:before {
  content: "\e031";
}

.glyphicon-list-alt:before {
  content: "\e032";
}

.glyphicon-lock:before {
  content: "\e033";
}

.glyphicon-flag:before {
  content: "\e034";
}

.glyphicon-headphones:before {
  content: "\e035";
}

.glyphicon-volume-off:before {
  content: "\e036";
}

.glyphicon-volume-down:before {
  content: "\e037";
}

.glyphicon-volume-up:before {
  content: "\e038";
}

.glyphicon-qrcode:before {
  content: "\e039";
}

.glyphicon-barcode:before {
  content: "\e040";
}

.glyphicon-tag:before {
  content: "\e041";
}

.glyphicon-tags:before {
  content: "\e042";
}

.glyphicon-book:before {
  content: "\e043";
}

.glyphicon-bookmark:before {
  content: "\e044";
}

.glyphicon-print:before {
  content: "\e045";
}

.glyphicon-camera:before {
  content: "\e046";
}

.glyphicon-font:before {
  content: "\e047";
}

.glyphicon-bold:before {
  content: "\e048";
}

.glyphicon-italic:before {
  content: "\e049";
}

.glyphicon-text-height:before {
  content: "\e050";
}

.glyphicon-text-width:before {
  content: "\e051";
}

.glyphicon-align-left:before {
  content: "\e052";
}

.glyphicon-align-center:before {
  content: "\e053";
}

.glyphicon-align-right:before {
  content: "\e054";
}

.glyphicon-align-justify:before {
  content: "\e055";
}

.glyphicon-list:before {
  content: "\e056";
}

.glyphicon-indent-left:before {
  content: "\e057";
}

.glyphicon-indent-right:before {
  content: "\e058";
}

.glyphicon-facetime-video:before {
  content: "\e059";
}

.glyphicon-picture:before {
  content: "\e060";
}

.glyphicon-map-marker:before {
  content: "\e062";
}

.glyphicon-adjust:before {
  content: "\e063";
}

.glyphicon-tint:before {
  content: "\e064";
}

.glyphicon-edit:before {
  content: "\e065";
}

.glyphicon-share:before {
  content: "\e066";
}

.glyphicon-check:before {
  content: "\e067";
}

.glyphicon-move:before {
  content: "\e068";
}

.glyphicon-step-backward:before {
  content: "\e069";
}

.glyphicon-fast-backward:before {
  content: "\e070";
}

.glyphicon-backward:before {
  content: "\e071";
}

.glyphicon-play:before {
  content: "\e072";
}

.glyphicon-pause:before {
  content: "\e073";
}

.glyphicon-stop:before {
  content: "\e074";
}

.glyphicon-forward:before {
  content: "\e075";
}

.glyphicon-fast-forward:before {
  content: "\e076";
}

.glyphicon-step-forward:before {
  content: "\e077";
}

.glyphicon-eject:before {
  content: "\e078";
}

.glyphicon-chevron-left:before {
  content: "\e079";
}

.glyphicon-chevron-right:before {
  content: "\e080";
}

.glyphicon-plus-sign:before {
  content: "\e081";
}

.glyphicon-minus-sign:before {
  content: "\e082";
}

.glyphicon-remove-sign:before {
  content: "\e083";
}

.glyphicon-ok-sign:before {
  content: "\e084";
}

.glyphicon-question-sign:before {
  content: "\e085";
}

.glyphicon-info-sign:before {
  content: "\e086";
}

.glyphicon-screenshot:before {
  content: "\e087";
}

.glyphicon-remove-circle:before {
  content: "\e088";
}

.glyphicon-ok-circle:before {
  content: "\e089";
}

.glyphicon-ban-circle:before {
  content: "\e090";
}

.glyphicon-arrow-left:before {
  content: "\e091";
}

.glyphicon-arrow-right:before {
  content: "\e092";
}

.glyphicon-arrow-up:before {
  content: "\e093";
}

.glyphicon-arrow-down:before {
  content: "\e094";
}

.glyphicon-share-alt:before {
  content: "\e095";
}

.glyphicon-resize-full:before {
  content: "\e096";
}

.glyphicon-resize-small:before {
  content: "\e097";
}

.glyphicon-exclamation-sign:before {
  content: "\e101";
}

.glyphicon-gift:before {
  content: "\e102";
}

.glyphicon-leaf:before {
  content: "\e103";
}

.glyphicon-fire:before {
  content: "\e104";
}

.glyphicon-eye-open:before {
  content: "\e105";
}

.glyphicon-eye-close:before {
  content: "\e106";
}

.glyphicon-warning-sign:before {
  content: "\e107";
}

.glyphicon-plane:before {
  content: "\e108";
}

.glyphicon-calendar:before {
  content: "\e109";
}

.glyphicon-random:before {
  content: "\e110";
}

.glyphicon-comment:before {
  content: "\e111";
}

.glyphicon-magnet:before {
  content: "\e112";
}

.glyphicon-chevron-up:before {
  content: "\e113";
}

.glyphicon-chevron-down:before {
  content: "\e114";
}

.glyphicon-retweet:before {
  content: "\e115";
}

.glyphicon-shopping-cart:before {
  content: "\e116";
}

.glyphicon-folder-close:before {
  content: "\e117";
}

.glyphicon-folder-open:before {
  content: "\e118";
}

.glyphicon-resize-vertical:before {
  content: "\e119";
}

.glyphicon-resize-horizontal:before {
  content: "\e120";
}

.glyphicon-hdd:before {
  content: "\e121";
}

.glyphicon-bullhorn:before {
  content: "\e122";
}

.glyphicon-bell:before {
  content: "\e123";
}

.glyphicon-certificate:before {
  content: "\e124";
}

.glyphicon-thumbs-up:before {
  content: "\e125";
}

.glyphicon-thumbs-down:before {
  content: "\e126";
}

.glyphicon-hand-right:before {
  content: "\e127";
}

.glyphicon-hand-left:before {
  content: "\e128";
}

.glyphicon-hand-up:before {
  content: "\e129";
}

.glyphicon-hand-down:before {
  content: "\e130";
}

.glyphicon-circle-arrow-right:before {
  content: "\e131";
}

.glyphicon-circle-arrow-left:before {
  content: "\e132";
}

.glyphicon-circle-arrow-up:before {
  content: "\e133";
}

.glyphicon-circle-arrow-down:before {
  content: "\e134";
}

.glyphicon-globe:before {
  content: "\e135";
}

.glyphicon-wrench:before {
  content: "\e136";
}

.glyphicon-tasks:before {
  content: "\e137";
}

.glyphicon-filter:before {
  content: "\e138";
}

.glyphicon-briefcase:before {
  content: "\e139";
}

.glyphicon-fullscreen:before {
  content: "\e140";
}

.glyphicon-dashboard:before {
  content: "\e141";
}

.glyphicon-paperclip:before {
  content: "\e142";
}

.glyphicon-heart-empty:before {
  content: "\e143";
}

.glyphicon-link:before {
  content: "\e144";
}

.glyphicon-phone:before {
  content: "\e145";
}

.glyphicon-pushpin:before {
  content: "\e146";
}

.glyphicon-usd:before {
  content: "\e148";
}

.glyphicon-gbp:before {
  content: "\e149";
}

.glyphicon-sort:before {
  content: "\e150";
}

.glyphicon-sort-by-alphabet:before {
  content: "\e151";
}

.glyphicon-sort-by-alphabet-alt:before {
  content: "\e152";
}

.glyphicon-sort-by-order:before {
  content: "\e153";
}

.glyphicon-sort-by-order-alt:before {
  content: "\e154";
}

.glyphicon-sort-by-attributes:before {
  content: "\e155";
}

.glyphicon-sort-by-attributes-alt:before {
  content: "\e156";
}

.glyphicon-unchecked:before {
  content: "\e157";
}

.glyphicon-expand:before {
  content: "\e158";
}

.glyphicon-collapse-down:before {
  content: "\e159";
}

.glyphicon-collapse-up:before {
  content: "\e160";
}

.glyphicon-log-in:before {
  content: "\e161";
}

.glyphicon-flash:before {
  content: "\e162";
}

.glyphicon-log-out:before {
  content: "\e163";
}

.glyphicon-new-window:before {
  content: "\e164";
}

.glyphicon-record:before {
  content: "\e165";
}

.glyphicon-save:before {
  content: "\e166";
}

.glyphicon-open:before {
  content: "\e167";
}

.glyphicon-saved:before {
  content: "\e168";
}

.glyphicon-import:before {
  content: "\e169";
}

.glyphicon-export:before {
  content: "\e170";
}

.glyphicon-send:before {
  content: "\e171";
}

.glyphicon-floppy-disk:before {
  content: "\e172";
}

.glyphicon-floppy-saved:before {
  content: "\e173";
}

.glyphicon-floppy-remove:before {
  content: "\e174";
}

.glyphicon-floppy-save:before {
  content: "\e175";
}

.glyphicon-floppy-open:before {
  content: "\e176";
}

.glyphicon-credit-card:before {
  content: "\e177";
}

.glyphicon-transfer:before {
  content: "\e178";
}

.glyphicon-cutlery:before {
  content: "\e179";
}

.glyphicon-header:before {
  content: "\e180";
}

.glyphicon-compressed:before {
  content: "\e181";
}

.glyphicon-earphone:before {
  content: "\e182";
}

.glyphicon-phone-alt:before {
  content: "\e183";
}

.glyphicon-tower:before {
  content: "\e184";
}

.glyphicon-stats:before {
  content: "\e185";
}

.glyphicon-sd-video:before {
  content: "\e186";
}

.glyphicon-hd-video:before {
  content: "\e187";
}

.glyphicon-subtitles:before {
  content: "\e188";
}

.glyphicon-sound-stereo:before {
  content: "\e189";
}

.glyphicon-sound-dolby:before {
  content: "\e190";
}

.glyphicon-sound-5-1:before {
  content: "\e191";
}

.glyphicon-sound-6-1:before {
  content: "\e192";
}

.glyphicon-sound-7-1:before {
  content: "\e193";
}

.glyphicon-copyright-mark:before {
  content: "\e194";
}

.glyphicon-registration-mark:before {
  content: "\e195";
}

.glyphicon-cloud-download:before {
  content: "\e197";
}

.glyphicon-cloud-upload:before {
  content: "\e198";
}

.glyphicon-tree-conifer:before {
  content: "\e199";
}

.glyphicon-tree-deciduous:before {
  content: "\e200";
}

.caret {
  display: inline-block;
  width: 0;
  height: 0;
  margin-left: 2px;
  vertical-align: middle;
  border-top: 4px solid #000000;
  border-right: 4px solid transparent;
  border-bottom: 0 dotted;
  border-left: 4px solid transparent;
}

.dropdown {
  position: relative;
}

.dropdown-toggle:focus {
  outline: 0;
}

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 1000;
  display: none;
  float: left;
  min-width: 160px;
  padding: 5px 0;
  margin: 2px 0 0;
  font-size: 16px;
  list-style: none;
  background-color: #ffffff;
  border: 1px solid #cccccc;
  border: 1px solid rgba(0, 0, 0, 0.15);
  border-radius: 0.5em;
  -webkit-box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
          box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  background-clip: padding-box;
}

.dropdown-menu.pull-right {
  right: 0;
  left: auto;
}

.dropdown-menu .divider {
  height: 1px;
  margin: 10px 0;
  overflow: hidden;
  background-color: #e5e5e5;
}

.dropdown-menu > li > a {
  display: block;
  padding: 3px 20px;
  clear: both;
  font-weight: normal;
  line-height: 1.428571429;
  color: #333333;
  white-space: nowrap;
}

.dropdown-menu > li > a:hover,
.dropdown-menu > li > a:focus {
  color: #333333;
  text-decoration: none;
  background-color: #ebeff9;
}

.dropdown-menu > .active > a,
.dropdown-menu > .active > a:hover,
.dropdown-menu > .active > a:focus {
  color: #ffffff;
  text-decoration: none;
  background-color: #ebeff9;
  outline: 0;
}

.dropdown-menu > .disabled > a,
.dropdown-menu > .disabled > a:hover,
.dropdown-menu > .disabled > a:focus {
  color: #999999;
}

.dropdown-menu > .disabled > a:hover,
.dropdown-menu > .disabled > a:focus {
  text-decoration: none;
  cursor: not-allowed;
  background-color: transparent;
  background-image: none;
  filter: progid:DXImageTransform.Microsoft.gradient(enabled=false);
}

.open > .dropdown-menu {
  display: block;
}

.open > a {
  outline: 0;
}

.dropdown-header {
  display: block;
  padding: 3px 20px;
  font-size: 14px;
  line-height: 1.428571429;
  color: #732843;
}

.dropdown-backdrop {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 990;
}

.pull-right > .dropdown-menu {
  right: 0;
  left: auto;
}

.dropup .caret,
.navbar-fixed-bottom .dropdown .caret {
  border-top: 0 dotted;
  border-bottom: 4px solid #000000;
  content: "";
}

.dropup .dropdown-menu,
.navbar-fixed-bottom .dropdown .dropdown-menu {
  top: auto;
  bottom: 100%;
  margin-bottom: 1px;
}

@media (min-width: 768px) {
  .navbar-right .dropdown-menu {
    right: 0;
    left: auto;
  }
}

.btn-default .caret {
  border-top-color: #2f4fa2;
}

.btn-primary .caret,
.btn-success .caret,
.btn-warning .caret,
.btn-danger .caret,
.btn-info .caret {
  border-top-color: #fff;
}

.dropup .btn-default .caret {
  border-bottom-color: #2f4fa2;
}

.dropup .btn-primary .caret,
.dropup .btn-success .caret,
.dropup .btn-warning .caret,
.dropup .btn-danger .caret,
.dropup .btn-info .caret {
  border-bottom-color: #fff;
}

.btn-group,
.btn-group-vertical {
  position: relative;
  display: inline-block;
  vertical-align: middle;
}

.btn-group > .btn,
.btn-group-vertical > .btn {
  position: relative;
  float: left;
}

.btn-group > .btn:hover,
.btn-group-vertical > .btn:hover,
.btn-group > .btn:focus,
.btn-group-vertical > .btn:focus,
.btn-group > .btn:active,
.btn-group-vertical > .btn:active,
.btn-group > .btn.active,
.btn-group-vertical > .btn.active {
  z-index: 2;
}

.btn-group > .btn:focus,
.btn-group-vertical > .btn:focus {
  outline: none;
}

.btn-group .btn + .btn,
.btn-group .btn + .btn-group,
.btn-group .btn-group + .btn,
.btn-group .btn-group + .btn-group {
  margin-left: -1px;
}

.btn-toolbar:before,
.btn-toolbar:after {
  display: table;
  content: " ";
}

.btn-toolbar:after {
  clear: both;
}

.btn-toolbar:before,
.btn-toolbar:after {
  display: table;
  content: " ";
}

.btn-toolbar:after {
  clear: both;
}

.btn-toolbar .btn-group {
  float: left;
}

.btn-toolbar > .btn + .btn,
.btn-toolbar > .btn-group + .btn,
.btn-toolbar > .btn + .btn-group,
.btn-toolbar > .btn-group + .btn-group {
  margin-left: 5px;
}

.btn-group > .btn:not(:first-child):not(:last-child):not(.dropdown-toggle) {
  border-radius: 0;
}

.btn-group > .btn:first-child {
  margin-left: 0;
}

.btn-group > .btn:first-child:not(:last-child):not(.dropdown-toggle) {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.btn-group > .btn:last-child:not(:first-child),
.btn-group > .dropdown-toggle:not(:first-child) {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
}

.btn-group > .btn-group {
  float: left;
}

.btn-group > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0;
}

.btn-group > .btn-group:first-child > .btn:last-child,
.btn-group > .btn-group:first-child > .dropdown-toggle {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.btn-group > .btn-group:last-child > .btn:first-child {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
}

.btn-group .dropdown-toggle:active,
.btn-group.open .dropdown-toggle {
  outline: 0;
}

.btn-group-xs > .btn {
  padding: 5px 10px;
  padding: 1px 5px;
  font-size: 14px;
  line-height: 1.5;
  border-radius: 0.5em;
}

.btn-group-sm > .btn {
  padding: 5px 10px;
  font-size: 14px;
  line-height: 1.5;
  border-radius: 0.5em;
}

.btn-group-lg > .btn {
  padding: 10px 16px;
  font-size: 20px;
  line-height: 1.33;
  border-radius: 0.5em;
}

.btn-group > .btn + .dropdown-toggle {
  padding-right: 8px;
  padding-left: 8px;
}

.btn-group > .btn-lg + .dropdown-toggle {
  padding-right: 12px;
  padding-left: 12px;
}

.btn-group.open .dropdown-toggle {
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
          box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
}

.btn .caret {
  margin-left: 0;
}

.btn-lg .caret {
  border-width: 5px 5px 0;
  border-bottom-width: 0;
}

.dropup .btn-lg .caret {
  border-width: 0 5px 5px;
}

.btn-group-vertical > .btn,
.btn-group-vertical > .btn-group {
  display: block;
  float: none;
  width: 100%;
  max-width: 100%;
}

.btn-group-vertical > .btn-group:before,
.btn-group-vertical > .btn-group:after {
  display: table;
  content: " ";
}

.btn-group-vertical > .btn-group:after {
  clear: both;
}

.btn-group-vertical > .btn-group:before,
.btn-group-vertical > .btn-group:after {
  display: table;
  content: " ";
}

.btn-group-vertical > .btn-group:after {
  clear: both;
}

.btn-group-vertical > .btn-group > .btn {
  float: none;
}

.btn-group-vertical > .btn + .btn,
.btn-group-vertical > .btn + .btn-group,
.btn-group-vertical > .btn-group + .btn,
.btn-group-vertical > .btn-group + .btn-group {
  margin-top: -1px;
  margin-left: 0;
}

.btn-group-vertical > .btn:not(:first-child):not(:last-child) {
  border-radius: 0;
}

.btn-group-vertical > .btn:first-child:not(:last-child) {
  border-top-right-radius: 0.5em;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}

.btn-group-vertical > .btn:last-child:not(:first-child) {
  border-top-right-radius: 0;
  border-bottom-left-radius: 0.5em;
  border-top-left-radius: 0;
}

.btn-group-vertical > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0;
}

.btn-group-vertical > .btn-group:first-child > .btn:last-child,
.btn-group-vertical > .btn-group:first-child > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}

.btn-group-vertical > .btn-group:last-child > .btn:first-child {
  border-top-right-radius: 0;
  border-top-left-radius: 0;
}

.btn-group-justified {
  display: table;
  width: 100%;
  border-collapse: separate;
  table-layout: fixed;
}

.btn-group-justified .btn {
  display: table-cell;
  float: none;
  width: 1%;
}

[data-toggle="buttons"] > .btn > input[type="radio"],
[data-toggle="buttons"] > .btn > input[type="checkbox"] {
  display: none;
}

.input-group {
  position: relative;
  display: table;
  border-collapse: separate;
}

.input-group.col {
  float: none;
  padding-right: 0;
  padding-left: 0;
}

.input-group .form-control {
  width: 100%;
  margin-bottom: 0;
}

.input-group-lg > .form-control,
.input-group-lg > .input-group-addon,
.input-group-lg > .input-group-btn > .btn {
  height: 48px;
  padding: 10px 16px;
  font-size: 20px;
  line-height: 1.33;
  border-radius: 0.5em;
}

select.input-group-lg > .form-control,
select.input-group-lg > .input-group-addon,
select.input-group-lg > .input-group-btn > .btn {
  height: 48px;
  line-height: 48px;
}

textarea.input-group-lg > .form-control,
textarea.input-group-lg > .input-group-addon,
textarea.input-group-lg > .input-group-btn > .btn {
  height: auto;
}

.input-group-sm > .form-control,
.input-group-sm > .input-group-addon,
.input-group-sm > .input-group-btn > .btn {
  height: 33px;
  padding: 5px 10px;
  font-size: 14px;
  line-height: 1.5;
  border-radius: 0.5em;
}

select.input-group-sm > .form-control,
select.input-group-sm > .input-group-addon,
select.input-group-sm > .input-group-btn > .btn {
  height: 33px;
  line-height: 33px;
}

textarea.input-group-sm > .form-control,
textarea.input-group-sm > .input-group-addon,
textarea.input-group-sm > .input-group-btn > .btn {
  height: auto;
}

.input-group-addon,
.input-group-btn,
.input-group .form-control {
  display: table-cell;
}

.input-group-addon:not(:first-child):not(:last-child),
.input-group-btn:not(:first-child):not(:last-child),
.input-group .form-control:not(:first-child):not(:last-child) {
  border-radius: 0;
}

.input-group-addon,
.input-group-btn {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle;
}

.input-group-addon {
  padding: 6px 12px;
  font-size: 16px;
  font-weight: normal;
  line-height: 1;
  color: #555555;
  text-align: center;
  background-color: #eeeeee;
  border: 1px solid #979ca1;
  border-radius: 0.5em;
}

.input-group-addon.input-sm {
  padding: 5px 10px;
  font-size: 14px;
  border-radius: 0.5em;
}

.input-group-addon.input-lg {
  padding: 10px 16px;
  font-size: 20px;
  border-radius: 0.5em;
}

.input-group-addon input[type="radio"],
.input-group-addon input[type="checkbox"] {
  margin-top: 0;
}

.input-group .form-control:first-child,
.input-group-addon:first-child,
.input-group-btn:first-child > .btn,
.input-group-btn:first-child > .dropdown-toggle,
.input-group-btn:last-child > .btn:not(:last-child):not(.dropdown-toggle) {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.input-group-addon:first-child {
  border-right: 0;
}

.input-group .form-control:last-child,
.input-group-addon:last-child,
.input-group-btn:last-child > .btn,
.input-group-btn:last-child > .dropdown-toggle,
.input-group-btn:first-child > .btn:not(:first-child) {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0;
}

.input-group-addon:last-child {
  border-left: 0;
}

.input-group-btn {
  position: relative;
  white-space: nowrap;
}

.input-group-btn:first-child > .btn {
  margin-right: -1px;
}

.input-group-btn:last-child > .btn {
  margin-left: -1px;
}

.input-group-btn > .btn {
  position: relative;
}

.input-group-btn > .btn + .btn {
  margin-left: -4px;
}

.input-group-btn > .btn:hover,
.input-group-btn > .btn:active {
  z-index: 2;
}

.nav {
  padding-left: 0;
  margin-bottom: 0;
  list-style: none;
}

.nav:before,
.nav:after {
  display: table;
  content: " ";
}

.nav:after {
  clear: both;
}

.nav:before,
.nav:after {
  display: table;
  content: " ";
}

.nav:after {
  clear: both;
}

.nav > li {
  position: relative;
  display: block;
}

.nav > li > a {
  position: relative;
  display: block;
  padding: 10px 15px;
}

.nav > li > a:hover,
.nav > li > a:focus {
  text-decoration: none;
  background-color: #eeeeee;
}

.nav > li.disabled > a {
  color: #999999;
}

.nav > li.disabled > a:hover,
.nav > li.disabled > a:focus {
  color: #999999;
  text-decoration: none;
  cursor: not-allowed;
  background-color: transparent;
}

.nav .open > a,
.nav .open > a:hover,
.nav .open > a:focus {
  background-color: #eeeeee;
  border-color: #2f4fa2;
}

.nav .open > a .caret,
.nav .open > a:hover .caret,
.nav .open > a:focus .caret {
  border-top-color: #1e3267;
  border-bottom-color: #1e3267;
}

.nav .nav-divider {
  height: 1px;
  margin: 10px 0;
  overflow: hidden;
  background-color: #e5e5e5;
}

.nav > li > a > img {
  max-width: none;
}

.nav-tabs {
  border-bottom: 1px solid #dddddd;
}

.nav-tabs > li {
  float: left;
  margin-bottom: -1px;
}

.nav-tabs > li > a {
  margin-right: 2px;
  line-height: 1.428571429;
  border: 1px solid transparent;
  border-radius: 0.5em 0.5em 0 0;
}

.nav-tabs > li > a:hover {
  border-color: #eeeeee #eeeeee #dddddd;
}

.nav-tabs > li.active > a,
.nav-tabs > li.active > a:hover,
.nav-tabs > li.active > a:focus {
  color: #555555;
  cursor: default;
  background-color: #ffffff;
  border: 1px solid #dddddd;
  border-bottom-color: transparent;
}

.nav-tabs.nav-justified {
  width: 100%;
  border-bottom: 0;
}

.nav-tabs.nav-justified > li {
  float: none;
}

.nav-tabs.nav-justified > li > a {
  margin-bottom: 5px;
  text-align: center;
}

@media (min-width: 768px) {
  .nav-tabs.nav-justified > li {
    display: table-cell;
    width: 1%;
  }
  .nav-tabs.nav-justified > li > a {
    margin-bottom: 0;
  }
}

.nav-tabs.nav-justified > li > a {
  margin-right: 0;
  border-radius: 0.5em;
}

.nav-tabs.nav-justified > .active > a,
.nav-tabs.nav-justified > .active > a:hover,
.nav-tabs.nav-justified > .active > a:focus {
  border: 1px solid #dddddd;
}

@media (min-width: 768px) {
  .nav-tabs.nav-justified > li > a {
    border-bottom: 1px solid #dddddd;
    border-radius: 0.5em 0.5em 0 0;
  }
  .nav-tabs.nav-justified > .active > a,
  .nav-tabs.nav-justified > .active > a:hover,
  .nav-tabs.nav-justified > .active > a:focus {
    border-bottom-color: #ffffff;
  }
}

.nav-pills > li {
  float: left;
}

.nav-pills > li > a {
  border-radius: 0.5em;
}

.nav-pills > li + li {
  margin-left: 2px;
}

.nav-pills > li.active > a,
.nav-pills > li.active > a:hover,
.nav-pills > li.active > a:focus {
  color: #ffffff;
  background-color: #732843;
}

.nav-pills > li.active > a .caret,
.nav-pills > li.active > a:hover .caret,
.nav-pills > li.active > a:focus .caret {
  border-top-color: #ffffff;
  border-bottom-color: #ffffff;
}

.nav-stacked > li {
  float: none;
}

.nav-stacked > li + li {
  margin-top: 2px;
  margin-left: 0;
}

.nav-justified {
  width: 100%;
}

.nav-justified > li {
  float: none;
}

.nav-justified > li > a {
  margin-bottom: 5px;
  text-align: center;
}

@media (min-width: 768px) {
  .nav-justified > li {
    display: table-cell;
    width: 1%;
  }
  .nav-justified > li > a {
    margin-bottom: 0;
  }
}

.nav-tabs-justified {
  border-bottom: 0;
}

.nav-tabs-justified > li > a {
  margin-right: 0;
  border-radius: 0.5em;
}

.nav-tabs-justified > .active > a,
.nav-tabs-justified > .active > a:hover,
.nav-tabs-justified > .active > a:focus {
  border: 1px solid #dddddd;
}

@media (min-width: 768px) {
  .nav-tabs-justified > li > a {
    border-bottom: 1px solid #dddddd;
    border-radius: 0.5em 0.5em 0 0;
  }
  .nav-tabs-justified > .active > a,
  .nav-tabs-justified > .active > a:hover,
  .nav-tabs-justified > .active > a:focus {
    border-bottom-color: #ffffff;
  }
}

.tabbable:before,
.tabbable:after {
  display: table;
  content: " ";
}

.tabbable:after {
  clear: both;
}

.tabbable:before,
.tabbable:after {
  display: table;
  content: " ";
}

.tabbable:after {
  clear: both;
}

.tab-content > .tab-pane,
.pill-content > .pill-pane {
  display: none;
}

.tab-content > .active,
.pill-content > .active {
  display: block;
}

.nav .caret {
  border-top-color: #2f4fa2;
  border-bottom-color: #2f4fa2;
}

.nav a:hover .caret {
  border-top-color: #1e3267;
  border-bottom-color: #1e3267;
}

.nav-tabs .dropdown-menu {
  margin-top: -1px;
  border-top-right-radius: 0;
  border-top-left-radius: 0;
}

.navbar {
  position: relative;
  z-index: 1000;
  min-height: 50px;
  margin-bottom: 22px;
  border: 1px solid transparent;
}

.navbar:before,
.navbar:after {
  display: table;
  content: " ";
}

.navbar:after {
  clear: both;
}

.navbar:before,
.navbar:after {
  display: table;
  content: " ";
}

.navbar:after {
  clear: both;
}

@media (min-width: 768px) {
  .navbar {
    border-radius: 0.5em;
  }
}

.navbar-header:before,
.navbar-header:after {
  display: table;
  content: " ";
}

.navbar-header:after {
  clear: both;
}

.navbar-header:before,
.navbar-header:after {
  display: table;
  content: " ";
}

.navbar-header:after {
  clear: both;
}

@media (min-width: 768px) {
  .navbar-header {
    float: left;
  }
}

.navbar-collapse {
  max-height: 340px;
  padding-right: 15px;
  padding-left: 15px;
  overflow-x: visible;
  border-top: 1px solid transparent;
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
  -webkit-overflow-scrolling: touch;
}

.navbar-collapse:before,
.navbar-collapse:after {
  display: table;
  content: " ";
}

.navbar-collapse:after {
  clear: both;
}

.navbar-collapse:before,
.navbar-collapse:after {
  display: table;
  content: " ";
}

.navbar-collapse:after {
  clear: both;
}

.navbar-collapse.in {
  overflow-y: auto;
}

@media (min-width: 768px) {
  .navbar-collapse {
    width: auto;
    border-top: 0;
    box-shadow: none;
  }
  .navbar-collapse.collapse {
    display: block !important;
    height: auto !important;
    padding-bottom: 0;
    overflow: visible !important;
  }
  .navbar-collapse.in {
    overflow-y: visible;
  }
  .navbar-collapse .navbar-nav.navbar-left:first-child {
    margin-left: -15px;
  }
  .navbar-collapse .navbar-nav.navbar-right:last-child {
    margin-right: -15px;
  }
  .navbar-collapse .navbar-text:last-child {
    margin-right: 0;
  }
}

.container > .navbar-header,
.container > .navbar-collapse {
  margin-right: -15px;
  margin-left: -15px;
}

@media (min-width: 768px) {
  .container > .navbar-header,
  .container > .navbar-collapse {
    margin-right: 0;
    margin-left: 0;
  }
}

.navbar-static-top {
  border-width: 0 0 1px;
}

@media (min-width: 768px) {
  .navbar-static-top {
    border-radius: 0;
  }
}

.navbar-fixed-top,
.navbar-fixed-bottom {
  position: fixed;
  right: 0;
  left: 0;
  border-width: 0 0 1px;
}

@media (min-width: 768px) {
  .navbar-fixed-top,
  .navbar-fixed-bottom {
    border-radius: 0;
  }
}

.navbar-fixed-top {
  top: 0;
  z-index: 1030;
}

.navbar-fixed-bottom {
  bottom: 0;
  margin-bottom: 0;
}

.navbar-brand {
  float: left;
  padding: 14px 15px;
  font-size: 20px;
  line-height: 22px;
}

.navbar-brand:hover,
.navbar-brand:focus {
  text-decoration: none;
}

@media (min-width: 768px) {
  .navbar > .container .navbar-brand {
    margin-left: -15px;
  }
}

.navbar-toggle {
  position: relative;
  float: right;
  padding: 9px 10px;
  margin-top: 8px;
  margin-right: 15px;
  margin-bottom: 8px;
  background-color: transparent;
  border: 1px solid transparent;
  border-radius: 0.5em;
}

.navbar-toggle .icon-bar {
  display: block;
  width: 22px;
  height: 2px;
  border-radius: 1px;
}

.navbar-toggle .icon-bar + .icon-bar {
  margin-top: 4px;
}

@media (min-width: 768px) {
  .navbar-toggle {
    display: none;
  }
}

.navbar-nav {
  margin: 7px -15px;
}

.navbar-nav > li > a {
  padding-top: 10px;
  padding-bottom: 10px;
  line-height: 22px;
}

@media (max-width: 767px) {
  .navbar-nav .open .dropdown-menu {
    position: static;
    float: none;
    width: auto;
    margin-top: 0;
    background-color: transparent;
    border: 0;
    box-shadow: none;
  }
  .navbar-nav .open .dropdown-menu > li > a,
  .navbar-nav .open .dropdown-menu .dropdown-header {
    padding: 5px 15px 5px 25px;
  }
  .navbar-nav .open .dropdown-menu > li > a {
    line-height: 22px;
  }
  .navbar-nav .open .dropdown-menu > li > a:hover,
  .navbar-nav .open .dropdown-menu > li > a:focus {
    background-image: none;
  }
}

@media (min-width: 768px) {
  .navbar-nav {
    float: left;
    margin: 0;
  }
  .navbar-nav > li {
    float: left;
  }
  .navbar-nav > li > a {
    padding-top: 14px;
    padding-bottom: 14px;
  }
}

@media (min-width: 768px) {
  .navbar-left {
    float: left !important;
  }
  .navbar-right {
    float: right !important;
  }
}

.navbar-form {
  padding: 10px 15px;
  margin-top: 7px;
  margin-right: -15px;
  margin-bottom: 7px;
  margin-left: -15px;
  border-top: 1px solid transparent;
  border-bottom: 1px solid transparent;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
          box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
}

@media (min-width: 768px) {
  .navbar-form .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle;
  }
  .navbar-form .form-control {
    display: inline-block;
  }
  .navbar-form .radio,
  .navbar-form .checkbox {
    display: inline-block;
    padding-left: 0;
    margin-top: 0;
    margin-bottom: 0;
  }
  .navbar-form .radio input[type="radio"],
  .navbar-form .checkbox input[type="checkbox"] {
    float: none;
    margin-left: 0;
  }
}

@media (max-width: 767px) {
  .navbar-form .form-group {
    margin-bottom: 5px;
  }
}

@media (min-width: 768px) {
  .navbar-form {
    width: auto;
    padding-top: 0;
    padding-bottom: 0;
    margin-right: 0;
    margin-left: 0;
    border: 0;
    -webkit-box-shadow: none;
            box-shadow: none;
  }
}

.navbar-nav > li > .dropdown-menu {
  margin-top: 0;
  border-top-right-radius: 0;
  border-top-left-radius: 0;
}

.navbar-fixed-bottom .navbar-nav > li > .dropdown-menu {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}

.navbar-nav.pull-right > li > .dropdown-menu,
.navbar-nav > li > .dropdown-menu.pull-right {
  right: 0;
  left: auto;
}

.navbar-btn {
  margin-top: 7px;
  margin-bottom: 7px;
}

.navbar-text {
  float: left;
  margin-top: 14px;
  margin-bottom: 14px;
}

@media (min-width: 768px) {
  .navbar-text {
    margin-right: 15px;
    margin-left: 15px;
  }
}

.navbar-default {
  background-color: #f8f8f8;
  border-color: #e7e7e7;
}

.navbar-default .navbar-brand {
  color: #777777;
}

.navbar-default .navbar-brand:hover,
.navbar-default .navbar-brand:focus {
  color: #5e5e5e;
  background-color: transparent;
}

.navbar-default .navbar-text {
  color: #777777;
}

.navbar-default .navbar-nav > li > a {
  color: #777777;
}

.navbar-default .navbar-nav > li > a:hover,
.navbar-default .navbar-nav > li > a:focus {
  color: #333333;
  background-color: transparent;
}

.navbar-default .navbar-nav > .active > a,
.navbar-default .navbar-nav > .active > a:hover,
.navbar-default .navbar-nav > .active > a:focus {
  color: #555555;
  background-color: #e7e7e7;
}

.navbar-default .navbar-nav > .disabled > a,
.navbar-default .navbar-nav > .disabled > a:hover,
.navbar-default .navbar-nav > .disabled > a:focus {
  color: #cccccc;
  background-color: transparent;
}

.navbar-default .navbar-toggle {
  border-color: #dddddd;
}

.navbar-default .navbar-toggle:hover,
.navbar-default .navbar-toggle:focus {
  background-color: #dddddd;
}

.navbar-default .navbar-toggle .icon-bar {
  background-color: #cccccc;
}

.navbar-default .navbar-collapse,
.navbar-default .navbar-form {
  border-color: #e7e7e7;
}

.navbar-default .navbar-nav > .dropdown > a:hover .caret,
.navbar-default .navbar-nav > .dropdown > a:focus .caret {
  border-top-color: #333333;
  border-bottom-color: #333333;
}

.navbar-default .navbar-nav > .open > a,
.navbar-default .navbar-nav > .open > a:hover,
.navbar-default .navbar-nav > .open > a:focus {
  color: #555555;
  background-color: #e7e7e7;
}

.navbar-default .navbar-nav > .open > a .caret,
.navbar-default .navbar-nav > .open > a:hover .caret,
.navbar-default .navbar-nav > .open > a:focus .caret {
  border-top-color: #555555;
  border-bottom-color: #555555;
}

.navbar-default .navbar-nav > .dropdown > a .caret {
  border-top-color: #777777;
  border-bottom-color: #777777;
}

@media (max-width: 767px) {
  .navbar-default .navbar-nav .open .dropdown-menu > li > a {
    color: #777777;
  }
  .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover,
  .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #333333;
    background-color: transparent;
  }
  .navbar-default .navbar-nav .open .dropdown-menu > .active > a,
  .navbar-default .navbar-nav .open .dropdown-menu > .active > a:hover,
  .navbar-default .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #555555;
    background-color: #e7e7e7;
  }
  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a,
  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:hover,
  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #cccccc;
    background-color: transparent;
  }
}

.navbar-default .navbar-link {
  color: #777777;
}

.navbar-default .navbar-link:hover {
  color: #333333;
}

.navbar-inverse {
  background-color: #222222;
  border-color: #080808;
}

.navbar-inverse .navbar-brand {
  color: #999999;
}

.navbar-inverse .navbar-brand:hover,
.navbar-inverse .navbar-brand:focus {
  color: #ffffff;
  background-color: transparent;
}

.navbar-inverse .navbar-text {
  color: #999999;
}

.navbar-inverse .navbar-nav > li > a {
  color: #999999;
}

.navbar-inverse .navbar-nav > li > a:hover,
.navbar-inverse .navbar-nav > li > a:focus {
  color: #ffffff;
  background-color: transparent;
}

.navbar-inverse .navbar-nav > .active > a,
.navbar-inverse .navbar-nav > .active > a:hover,
.navbar-inverse .navbar-nav > .active > a:focus {
  color: #ffffff;
  background-color: #080808;
}

.navbar-inverse .navbar-nav > .disabled > a,
.navbar-inverse .navbar-nav > .disabled > a:hover,
.navbar-inverse .navbar-nav > .disabled > a:focus {
  color: #444444;
  background-color: transparent;
}

.navbar-inverse .navbar-toggle {
  border-color: #333333;
}

.navbar-inverse .navbar-toggle:hover,
.navbar-inverse .navbar-toggle:focus {
  background-color: #333333;
}

.navbar-inverse .navbar-toggle .icon-bar {
  background-color: #ffffff;
}

.navbar-inverse .navbar-collapse,
.navbar-inverse .navbar-form {
  border-color: #101010;
}

.navbar-inverse .navbar-nav > .open > a,
.navbar-inverse .navbar-nav > .open > a:hover,
.navbar-inverse .navbar-nav > .open > a:focus {
  color: #ffffff;
  background-color: #080808;
}

.navbar-inverse .navbar-nav > .dropdown > a:hover .caret {
  border-top-color: #ffffff;
  border-bottom-color: #ffffff;
}

.navbar-inverse .navbar-nav > .dropdown > a .caret {
  border-top-color: #999999;
  border-bottom-color: #999999;
}

.navbar-inverse .navbar-nav > .open > a .caret,
.navbar-inverse .navbar-nav > .open > a:hover .caret,
.navbar-inverse .navbar-nav > .open > a:focus .caret {
  border-top-color: #ffffff;
  border-bottom-color: #ffffff;
}

@media (max-width: 767px) {
  .navbar-inverse .navbar-nav .open .dropdown-menu > .dropdown-header {
    border-color: #080808;
  }
  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a {
    color: #999999;
  }
  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:hover,
  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #ffffff;
    background-color: transparent;
  }
  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:hover,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #ffffff;
    background-color: #080808;
  }
  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:hover,
  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #444444;
    background-color: transparent;
  }
}

.navbar-inverse .navbar-link {
  color: #999999;
}

.navbar-inverse .navbar-link:hover {
  color: #ffffff;
}

.breadcrumb {
  padding: 8px 15px;
  margin-bottom: 22px;
  list-style: none;
  background-color: #f5f5f5;
  border-radius: 0.5em;
}

.breadcrumb > li {
  display: inline-block;
}

.breadcrumb > li + li:before {
  padding: 0 5px;
  color: #cccccc;
  content: "/\00a0";
}

.breadcrumb > .active {
  color: #999999;
}

.pagination {
  display: inline-block;
  padding-left: 0;
  margin: 22px 0;
  border-radius: 0.5em;
}

.pagination > li {
  display: inline;
}

.pagination > li > a,
.pagination > li > span {
  position: relative;
  float: left;
  padding: 6px 12px;
  margin-left: -1px;
  line-height: 1.428571429;
  text-decoration: none;
  background-color: #ffffff;
  border: 1px solid #dddddd;
}

.pagination > li:first-child > a,
.pagination > li:first-child > span {
  margin-left: 0;
  border-bottom-left-radius: 0.5em;
  border-top-left-radius: 0.5em;
}

.pagination > li:last-child > a,
.pagination > li:last-child > span {
  border-top-right-radius: 0.5em;
  border-bottom-right-radius: 0.5em;
}

.pagination > li > a:hover,
.pagination > li > span:hover,
.pagination > li > a:focus,
.pagination > li > span:focus {
  background-color: #eeeeee;
}

.pagination > .active > a,
.pagination > .active > span,
.pagination > .active > a:hover,
.pagination > .active > span:hover,
.pagination > .active > a:focus,
.pagination > .active > span:focus {
  z-index: 2;
  color: #ffffff;
  cursor: default;
  background-color: #732843;
  border-color: #732843;
}

.pagination > .disabled > span,
.pagination > .disabled > span:hover,
.pagination > .disabled > span:focus,
.pagination > .disabled > a,
.pagination > .disabled > a:hover,
.pagination > .disabled > a:focus {
  color: #999999;
  cursor: not-allowed;
  background-color: #ffffff;
  border-color: #dddddd;
}

.pagination-lg > li > a,
.pagination-lg > li > span {
  padding: 10px 16px;
  font-size: 20px;
}

.pagination-lg > li:first-child > a,
.pagination-lg > li:first-child > span {
  border-bottom-left-radius: 0.5em;
  border-top-left-radius: 0.5em;
}

.pagination-lg > li:last-child > a,
.pagination-lg > li:last-child > span {
  border-top-right-radius: 0.5em;
  border-bottom-right-radius: 0.5em;
}

.pagination-sm > li > a,
.pagination-sm > li > span {
  padding: 5px 10px;
  font-size: 14px;
}

.pagination-sm > li:first-child > a,
.pagination-sm > li:first-child > span {
  border-bottom-left-radius: 0.5em;
  border-top-left-radius: 0.5em;
}

.pagination-sm > li:last-child > a,
.pagination-sm > li:last-child > span {
  border-top-right-radius: 0.5em;
  border-bottom-right-radius: 0.5em;
}

.pager {
  padding-left: 0;
  margin: 22px 0;
  text-align: center;
  list-style: none;
}

.pager:before,
.pager:after {
  display: table;
  content: " ";
}

.pager:after {
  clear: both;
}

.pager:before,
.pager:after {
  display: table;
  content: " ";
}

.pager:after {
  clear: both;
}

.pager li {
  display: inline;
}

.pager li > a,
.pager li > span {
  display: inline-block;
  padding: 5px 14px;
  background-color: #ffffff;
  border: 1px solid #dddddd;
  border-radius: 15px;
}

.pager li > a:hover,
.pager li > a:focus {
  text-decoration: none;
  background-color: #eeeeee;
}

.pager .next > a,
.pager .next > span {
  float: right;
}

.pager .previous > a,
.pager .previous > span {
  float: left;
}

.pager .disabled > a,
.pager .disabled > a:hover,
.pager .disabled > a:focus,
.pager .disabled > span {
  color: #999999;
  cursor: not-allowed;
  background-color: #ffffff;
}

.label {
  display: inline;
  padding: .2em .6em .3em;
  font-size: 75%;
  font-weight: bold;
  line-height: 1;
  color: #ffffff;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: .25em;
}

.label[href]:hover,
.label[href]:focus {
  color: #ffffff;
  text-decoration: none;
  cursor: pointer;
}

.label:empty {
  display: none;
}

.label-default {
  background-color: #999999;
}

.label-default[href]:hover,
.label-default[href]:focus {
  background-color: #808080;
}

.label-primary {
  background-color: #732843;
}

.label-primary[href]:hover,
.label-primary[href]:focus {
  background-color: #4d1b2d;
}

.label-success {
  background-color: #5cb85c;
}

.label-success[href]:hover,
.label-success[href]:focus {
  background-color: #449d44;
}

.label-info {
  background-color: #5bc0de;
}

.label-info[href]:hover,
.label-info[href]:focus {
  background-color: #31b0d5;
}

.label-warning {
  background-color: #f0ad4e;
}

.label-warning[href]:hover,
.label-warning[href]:focus {
  background-color: #ec971f;
}

.label-danger {
  background-color: #d9534f;
}

.label-danger[href]:hover,
.label-danger[href]:focus {
  background-color: #c9302c;
}

.badge {
  display: inline-block;
  min-width: 10px;
  padding: 3px 7px;
  font-size: 14px;
  font-weight: bold;
  line-height: 1;
  color: #ffffff;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  background-color: #999999;
  border-radius: 10px;
}

.badge:empty {
  display: none;
}

a.badge:hover,
a.badge:focus {
  color: #ffffff;
  text-decoration: none;
  cursor: pointer;
}

.btn .badge {
  position: relative;
  top: -1px;
}

a.list-group-item.active > .badge,
.nav-pills > .active > a > .badge {
  color: #2f4fa2;
  background-color: #ffffff;
}

.nav-pills > li > a > .badge {
  margin-left: 3px;
}

.jumbotron {
  padding: 30px;
  margin-bottom: 30px;
  font-size: 24px;
  font-weight: 200;
  line-height: 2.1428571435;
  color: inherit;
  background-color: #eeeeee;
}

.jumbotron h1 {
  line-height: 1;
  color: inherit;
}

.jumbotron p {
  line-height: 1.4;
}

.container .jumbotron {
  border-radius: 0.5em;
}

@media screen and (min-width: 768px) {
  .jumbotron {
    padding-top: 48px;
    padding-bottom: 48px;
  }
  .container .jumbotron {
    padding-right: 60px;
    padding-left: 60px;
  }
  .jumbotron h1 {
    font-size: 72px;
  }
}

.thumbnail {
  display: inline-block;
  display: block;
  height: auto;
  max-width: 100%;
  padding: 4px;
  margin-bottom: 22px;
  line-height: 1.428571429;
  background-color: #ffffff;
  border: 1px solid #dddddd;
  border-radius: 0.5em;
  -webkit-transition: all 0.2s ease-in-out;
          transition: all 0.2s ease-in-out;
}

.thumbnail > img {
  display: block;
  height: auto;
  max-width: 100%;
}

a.thumbnail:hover,
a.thumbnail:focus {
  border-color: #2f4fa2;
}

.thumbnail > img {
  margin-right: auto;
  margin-left: auto;
}

.thumbnail .caption {
  padding: 9px;
  color: #333333;
}

.alert {
  padding: 15px;
  margin-bottom: 22px;
  border: 1px solid transparent;
  border-radius: 0.5em;
}

.alert h4 {
  margin-top: 0;
  color: inherit;
}

.alert .alert-link {
  font-weight: bold;
}

.alert > p,
.alert > ul {
  margin-bottom: 0;
}

.alert > p + p {
  margin-top: 5px;
}

.alert-dismissable {
  padding-right: 35px;
}

.alert-dismissable .close {
  position: relative;
  top: -2px;
  right: -21px;
  color: inherit;
}

.alert-success {
  color: #468847;
  background-color: #dff0d8;
  border-color: #d6e9c6;
}

.alert-success hr {
  border-top-color: #c9e2b3;
}

.alert-success .alert-link {
  color: #356635;
}

.alert-info {
  color: #3a87ad;
  background-color: #d9edf7;
  border-color: #bce8f1;
}

.alert-info hr {
  border-top-color: #a6e1ec;
}

.alert-info .alert-link {
  color: #2d6987;
}

.alert-warning {
  color: #c09853;
  background-color: #fcf8e3;
  border-color: #faebcc;
}

.alert-warning hr {
  border-top-color: #f7e1b5;
}

.alert-warning .alert-link {
  color: #a47e3c;
}

.alert-danger {
  color: #b94a48;
  background-color: #f2dede;
  border-color: #ebccd1;
}

.alert-danger hr {
  border-top-color: #e4b9c0;
}

.alert-danger .alert-link {
  color: #953b39;
}

@-webkit-keyframes progress-bar-stripes {
  from {
    background-position: 40px 0;
  }
  to {
    background-position: 0 0;
  }
}

@-moz-keyframes progress-bar-stripes {
  from {
    background-position: 40px 0;
  }
  to {
    background-position: 0 0;
  }
}

@-o-keyframes progress-bar-stripes {
  from {
    background-position: 0 0;
  }
  to {
    background-position: 40px 0;
  }
}

@keyframes progress-bar-stripes {
  from {
    background-position: 40px 0;
  }
  to {
    background-position: 0 0;
  }
}

.progress {
  height: 22px;
  margin-bottom: 22px;
  overflow: hidden;
  background-color: #f5f5f5;
  border-radius: 0.5em;
  -webkit-box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
          box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
}

.progress-bar {
  float: left;
  width: 0;
  height: 100%;
  font-size: 14px;
  line-height: 22px;
  color: #ffffff;
  text-align: center;
  background-color: #732843;
  -webkit-box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
          box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  -webkit-transition: width 0.6s ease;
          transition: width 0.6s ease;
}

.progress-striped .progress-bar {
  background-image: -webkit-gradient(linear, 0 100%, 100% 0, color-stop(0.25, rgba(255, 255, 255, 0.15)), color-stop(0.25, transparent), color-stop(0.5, transparent), color-stop(0.5, rgba(255, 255, 255, 0.15)), color-stop(0.75, rgba(255, 255, 255, 0.15)), color-stop(0.75, transparent), to(transparent));
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: -moz-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-size: 40px 40px;
}

.progress.active .progress-bar {
  -webkit-animation: progress-bar-stripes 2s linear infinite;
     -moz-animation: progress-bar-stripes 2s linear infinite;
      -ms-animation: progress-bar-stripes 2s linear infinite;
       -o-animation: progress-bar-stripes 2s linear infinite;
          animation: progress-bar-stripes 2s linear infinite;
}

.progress-bar-success {
  background-color: #5cb85c;
}

.progress-striped .progress-bar-success {
  background-image: -webkit-gradient(linear, 0 100%, 100% 0, color-stop(0.25, rgba(255, 255, 255, 0.15)), color-stop(0.25, transparent), color-stop(0.5, transparent), color-stop(0.5, rgba(255, 255, 255, 0.15)), color-stop(0.75, rgba(255, 255, 255, 0.15)), color-stop(0.75, transparent), to(transparent));
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: -moz-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
}

.progress-bar-info {
  background-color: #5bc0de;
}

.progress-striped .progress-bar-info {
  background-image: -webkit-gradient(linear, 0 100%, 100% 0, color-stop(0.25, rgba(255, 255, 255, 0.15)), color-stop(0.25, transparent), color-stop(0.5, transparent), color-stop(0.5, rgba(255, 255, 255, 0.15)), color-stop(0.75, rgba(255, 255, 255, 0.15)), color-stop(0.75, transparent), to(transparent));
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: -moz-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
}

.progress-bar-warning {
  background-color: #f0ad4e;
}

.progress-striped .progress-bar-warning {
  background-image: -webkit-gradient(linear, 0 100%, 100% 0, color-stop(0.25, rgba(255, 255, 255, 0.15)), color-stop(0.25, transparent), color-stop(0.5, transparent), color-stop(0.5, rgba(255, 255, 255, 0.15)), color-stop(0.75, rgba(255, 255, 255, 0.15)), color-stop(0.75, transparent), to(transparent));
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: -moz-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
}

.progress-bar-danger {
  background-color: #d9534f;
}

.progress-striped .progress-bar-danger {
  background-image: -webkit-gradient(linear, 0 100%, 100% 0, color-stop(0.25, rgba(255, 255, 255, 0.15)), color-stop(0.25, transparent), color-stop(0.5, transparent), color-stop(0.5, rgba(255, 255, 255, 0.15)), color-stop(0.75, rgba(255, 255, 255, 0.15)), color-stop(0.75, transparent), to(transparent));
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: -moz-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
}

.media,
.media-body {
  overflow: hidden;
  zoom: 1;
}

.media,
.media .media {
  margin-top: 15px;
}

.media:first-child {
  margin-top: 0;
}

.media-object {
  display: block;
}

.media-heading {
  margin: 0 0 5px;
}

.media > .pull-left {
  margin-right: 10px;
}

.media > .pull-right {
  margin-left: 10px;
}

.media-list {
  padding-left: 0;
  list-style: none;
}

.list-group {
  padding-left: 0;
  margin-bottom: 20px;
}

.list-group-item {
  position: relative;
  display: block;
  padding: 10px 15px;
  margin-bottom: -1px;
  background-color: #ffffff;
  border: 1px solid #dddddd;
}

.list-group-item:first-child {
  border-top-right-radius: 0.5em;
  border-top-left-radius: 0.5em;
}

.list-group-item:last-child {
  margin-bottom: 0;
  border-bottom-right-radius: 0.5em;
  border-bottom-left-radius: 0.5em;
}

.list-group-item > .badge {
  float: right;
}

.list-group-item > .badge + .badge {
  margin-right: 5px;
}

a.list-group-item {
  color: #555555;
}

a.list-group-item .list-group-item-heading {
  color: #333333;
}

a.list-group-item:hover,
a.list-group-item:focus {
  text-decoration: none;
  background-color: #f5f5f5;
}

.list-group-item.active,
.list-group-item.active:hover,
.list-group-item.active:focus {
  z-index: 2;
  color: #ffffff;
  background-color: #732843;
  border-color: #732843;
}

.list-group-item.active .list-group-item-heading,
.list-group-item.active:hover .list-group-item-heading,
.list-group-item.active:focus .list-group-item-heading {
  color: inherit;
}

.list-group-item.active .list-group-item-text,
.list-group-item.active:hover .list-group-item-text,
.list-group-item.active:focus .list-group-item-text {
  color: #d88fa9;
}

.list-group-item-heading {
  margin-top: 0;
  margin-bottom: 5px;
}

.list-group-item-text {
  margin-bottom: 0;
  line-height: 1.3;
}

.panel {
  margin-bottom: 22px;
  background-color: #ffffff;
  border: 1px solid transparent;
  border-radius: 0.5em;
  -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
          box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
}

.panel-body {
  padding: 15px;
}

.panel-body:before,
.panel-body:after {
  display: table;
  content: " ";
}

.panel-body:after {
  clear: both;
}

.panel-body:before,
.panel-body:after {
  display: table;
  content: " ";
}

.panel-body:after {
  clear: both;
}

.panel > .list-group {
  margin-bottom: 0;
}

.panel > .list-group .list-group-item {
  border-width: 1px 0;
}

.panel > .list-group .list-group-item:first-child {
  border-top-right-radius: 0;
  border-top-left-radius: 0;
}

.panel > .list-group .list-group-item:last-child {
  border-bottom: 0;
}

.panel-heading + .list-group .list-group-item:first-child {
  border-top-width: 0;
}

.panel > .table,
.panel > .table-responsive {
  margin-bottom: 0;
}

.panel > .panel-body + .table,
.panel > .panel-body + .table-responsive {
  border-top: 1px solid #dddddd;
}

.panel > .table-bordered,
.panel > .table-responsive > .table-bordered {
  border: 0;
}

.panel > .table-bordered > thead > tr > th:first-child,
.panel > .table-responsive > .table-bordered > thead > tr > th:first-child,
.panel > .table-bordered > tbody > tr > th:first-child,
.panel > .table-responsive > .table-bordered > tbody > tr > th:first-child,
.panel > .table-bordered > tfoot > tr > th:first-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > th:first-child,
.panel > .table-bordered > thead > tr > td:first-child,
.panel > .table-responsive > .table-bordered > thead > tr > td:first-child,
.panel > .table-bordered > tbody > tr > td:first-child,
.panel > .table-responsive > .table-bordered > tbody > tr > td:first-child,
.panel > .table-bordered > tfoot > tr > td:first-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > td:first-child {
  border-left: 0;
}

.panel > .table-bordered > thead > tr > th:last-child,
.panel > .table-responsive > .table-bordered > thead > tr > th:last-child,
.panel > .table-bordered > tbody > tr > th:last-child,
.panel > .table-responsive > .table-bordered > tbody > tr > th:last-child,
.panel > .table-bordered > tfoot > tr > th:last-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > th:last-child,
.panel > .table-bordered > thead > tr > td:last-child,
.panel > .table-responsive > .table-bordered > thead > tr > td:last-child,
.panel > .table-bordered > tbody > tr > td:last-child,
.panel > .table-responsive > .table-bordered > tbody > tr > td:last-child,
.panel > .table-bordered > tfoot > tr > td:last-child,
.panel > .table-responsive > .table-bordered > tfoot > tr > td:last-child {
  border-right: 0;
}

.panel > .table-bordered > thead > tr:last-child > th,
.panel > .table-responsive > .table-bordered > thead > tr:last-child > th,
.panel > .table-bordered > tbody > tr:last-child > th,
.panel > .table-responsive > .table-bordered > tbody > tr:last-child > th,
.panel > .table-bordered > tfoot > tr:last-child > th,
.panel > .table-responsive > .table-bordered > tfoot > tr:last-child > th,
.panel > .table-bordered > thead > tr:last-child > td,
.panel > .table-responsive > .table-bordered > thead > tr:last-child > td,
.panel > .table-bordered > tbody > tr:last-child > td,
.panel > .table-responsive > .table-bordered > tbody > tr:last-child > td,
.panel > .table-bordered > tfoot > tr:last-child > td,
.panel > .table-responsive > .table-bordered > tfoot > tr:last-child > td {
  border-bottom: 0;
}

.panel-heading {
  padding: 10px 15px;
  border-bottom: 1px solid transparent;
  border-top-right-radius: -0.5em;
  border-top-left-radius: -0.5em;
}

.panel-title {
  margin-top: 0;
  margin-bottom: 0;
  font-size: 18px;
}

.panel-title > a {
  color: inherit;
}

.panel-footer {
  padding: 10px 15px;
  background-color: #f5f5f5;
  border-top: 1px solid #dddddd;
  border-bottom-right-radius: -0.5em;
  border-bottom-left-radius: -0.5em;
}

.panel-group .panel {
  margin-bottom: 0;
  overflow: hidden;
  border-radius: 0.5em;
}

.panel-group .panel + .panel {
  margin-top: 5px;
}

.panel-group .panel-heading {
  border-bottom: 0;
}

.panel-group .panel-heading + .panel-collapse .panel-body {
  border-top: 1px solid #dddddd;
}

.panel-group .panel-footer {
  border-top: 0;
}

.panel-group .panel-footer + .panel-collapse .panel-body {
  border-bottom: 1px solid #dddddd;
}

.panel-default {
  border-color: #dddddd;
}

.panel-default > .panel-heading {
  color: #333333;
  background-color: #f5f5f5;
  border-color: #dddddd;
}

.panel-default > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #dddddd;
}

.panel-default > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #dddddd;
}

.panel-primary {
  border-color: #732843;
}

.panel-primary > .panel-heading {
  color: #ffffff;
  background-color: #732843;
  border-color: #732843;
}

.panel-primary > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #732843;
}

.panel-primary > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #732843;
}

.panel-success {
  border-color: #d6e9c6;
}

.panel-success > .panel-heading {
  color: #468847;
  background-color: #dff0d8;
  border-color: #d6e9c6;
}

.panel-success > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #d6e9c6;
}

.panel-success > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #d6e9c6;
}

.panel-warning {
  border-color: #faebcc;
}

.panel-warning > .panel-heading {
  color: #c09853;
  background-color: #fcf8e3;
  border-color: #faebcc;
}

.panel-warning > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #faebcc;
}

.panel-warning > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #faebcc;
}

.panel-danger {
  border-color: #ebccd1;
}

.panel-danger > .panel-heading {
  color: #b94a48;
  background-color: #f2dede;
  border-color: #ebccd1;
}

.panel-danger > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #ebccd1;
}

.panel-danger > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #ebccd1;
}

.panel-info {
  border-color: #bce8f1;
}

.panel-info > .panel-heading {
  color: #3a87ad;
  background-color: #d9edf7;
  border-color: #bce8f1;
}

.panel-info > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #bce8f1;
}

.panel-info > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #bce8f1;
}

.well {
  min-height: 20px;
  padding: 19px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border: 1px solid #e3e3e3;
  border-radius: 0.5em;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
          box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
}

.well blockquote {
  border-color: #ddd;
  border-color: rgba(0, 0, 0, 0.15);
}

.well-lg {
  padding: 24px;
  border-radius: 0.5em;
}

.well-sm {
  padding: 9px;
  border-radius: 0.5em;
}

.close {
  float: right;
  font-size: 24px;
  font-weight: bold;
  line-height: 1;
  color: #000000;
  text-shadow: 0 1px 0 #ffffff;
  opacity: 0.2;
  filter: alpha(opacity=20);
}

.close:hover,
.close:focus {
  color: #000000;
  text-decoration: none;
  cursor: pointer;
  opacity: 0.5;
  filter: alpha(opacity=50);
}

button.close {
  padding: 0;
  cursor: pointer;
  background: transparent;
  border: 0;
  -webkit-appearance: none;
}

.modal-open {
  overflow: hidden;
}

.modal {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1040;
  display: none;
  overflow: auto;
  overflow-y: scroll;
}

.modal.fade .modal-dialog {
  -webkit-transform: translate(0, -25%);
      -ms-transform: translate(0, -25%);
          transform: translate(0, -25%);
  -webkit-transition: -webkit-transform 0.3s ease-out;
     -moz-transition: -moz-transform 0.3s ease-out;
       -o-transition: -o-transform 0.3s ease-out;
          transition: transform 0.3s ease-out;
}

.modal.in .modal-dialog {
  -webkit-transform: translate(0, 0);
      -ms-transform: translate(0, 0);
          transform: translate(0, 0);
}

.modal-dialog {
  z-index: 1050;
  width: auto;
  padding: 10px;
  margin-right: auto;
  margin-left: auto;
}

.modal-content {
  position: relative;
  background-color: #ffffff;
  border: 1px solid #999999;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 0.5em;
  outline: none;
  -webkit-box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
          box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  background-clip: padding-box;
}

.modal-backdrop {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1030;
  background-color: #155570;
}

.modal-backdrop.fade {
  opacity: 0;
  filter: alpha(opacity=0);
}

.modal-backdrop.in {
  opacity: 0.5;
  filter: alpha(opacity=50);
}

.modal-header {
  min-height: 16.428571429px;
  padding: 15px;
  border-bottom: 1px solid #e5e5e5;
}

.modal-header .close {
  margin-top: -2px;
}

.modal-title {
  margin: 0;
  line-height: 1.428571429;
}

.modal-body {
  position: relative;
  padding: 20px;
}

.modal-footer {
  padding: 19px 20px 20px;
  margin-top: 15px;
  text-align: right;
  border-top: 1px solid #e5e5e5;
}

.modal-footer:before,
.modal-footer:after {
  display: table;
  content: " ";
}

.modal-footer:after {
  clear: both;
}

.modal-footer:before,
.modal-footer:after {
  display: table;
  content: " ";
}

.modal-footer:after {
  clear: both;
}

.modal-footer .btn + .btn {
  margin-bottom: 0;
  margin-left: 5px;
}

.modal-footer .btn-group .btn + .btn {
  margin-left: -1px;
}

.modal-footer .btn-block + .btn-block {
  margin-left: 0;
}

@media screen and (min-width: 768px) {
  .modal-dialog {
    width: 600px;
    padding-top: 30px;
    padding-bottom: 30px;
  }
  .modal-content {
    -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
  }
}

.tooltip {
  position: absolute;
  z-index: 1030;
  display: block;
  font-size: 14px;
  line-height: 1.4;
  opacity: 0;
  filter: alpha(opacity=0);
  visibility: visible;
}

.tooltip.in {
  opacity: 0.9;
  filter: alpha(opacity=90);
}

.tooltip.top {
  padding: 5px 0;
  margin-top: -3px;
}

.tooltip.right {
  padding: 0 5px;
  margin-left: 3px;
}

.tooltip.bottom {
  padding: 5px 0;
  margin-top: 3px;
}

.tooltip.left {
  padding: 0 5px;
  margin-left: -3px;
}

.tooltip-inner {
  max-width: 200px;
  padding: 3px 8px;
  color: #ffffff;
  text-align: center;
  text-decoration: none;
  background-color: #000000;
  border-radius: 0.5em;
}

.tooltip-arrow {
  position: absolute;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid;
}

.tooltip.top .tooltip-arrow {
  bottom: 0;
  left: 50%;
  margin-left: -5px;
  border-top-color: #000000;
  border-width: 5px 5px 0;
}

.tooltip.top-left .tooltip-arrow {
  bottom: 0;
  left: 5px;
  border-top-color: #000000;
  border-width: 5px 5px 0;
}

.tooltip.top-right .tooltip-arrow {
  right: 5px;
  bottom: 0;
  border-top-color: #000000;
  border-width: 5px 5px 0;
}

.tooltip.right .tooltip-arrow {
  top: 50%;
  left: 0;
  margin-top: -5px;
  border-right-color: #000000;
  border-width: 5px 5px 5px 0;
}

.tooltip.left .tooltip-arrow {
  top: 50%;
  right: 0;
  margin-top: -5px;
  border-left-color: #000000;
  border-width: 5px 0 5px 5px;
}

.tooltip.bottom .tooltip-arrow {
  top: 0;
  left: 50%;
  margin-left: -5px;
  border-bottom-color: #000000;
  border-width: 0 5px 5px;
}

.tooltip.bottom-left .tooltip-arrow {
  top: 0;
  left: 5px;
  border-bottom-color: #000000;
  border-width: 0 5px 5px;
}

.tooltip.bottom-right .tooltip-arrow {
  top: 0;
  right: 5px;
  border-bottom-color: #000000;
  border-width: 0 5px 5px;
}

.popover {
  position: absolute;
  top: 0;
  left: 0;
  z-index: 1010;
  display: none;
  max-width: 276px;
  padding: 1px;
  text-align: left;
  white-space: normal;
  background-color: #ffffff;
  border: 1px solid #cccccc;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 0.5em;
  -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
          box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  background-clip: padding-box;
}

.popover.top {
  margin-top: -10px;
}

.popover.right {
  margin-left: 10px;
}

.popover.bottom {
  margin-top: 10px;
}

.popover.left {
  margin-left: -10px;
}

.popover-title {
  padding: 8px 14px;
  margin: 0;
  font-size: 16px;
  font-weight: normal;
  line-height: 18px;
  background-color: #f7f7f7;
  border-bottom: 1px solid #ebebeb;
  border-radius: 5px 5px 0 0;
}

.popover-content {
  padding: 9px 14px;
}

.popover .arrow,
.popover .arrow:after {
  position: absolute;
  display: block;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid;
}

.popover .arrow {
  border-width: 11px;
}

.popover .arrow:after {
  border-width: 10px;
  content: "";
}

.popover.top .arrow {
  bottom: -11px;
  left: 50%;
  margin-left: -11px;
  border-top-color: #999999;
  border-top-color: rgba(0, 0, 0, 0.25);
  border-bottom-width: 0;
}

.popover.top .arrow:after {
  bottom: 1px;
  margin-left: -10px;
  border-top-color: #ffffff;
  border-bottom-width: 0;
  content: " ";
}

.popover.right .arrow {
  top: 50%;
  left: -11px;
  margin-top: -11px;
  border-right-color: #999999;
  border-right-color: rgba(0, 0, 0, 0.25);
  border-left-width: 0;
}

.popover.right .arrow:after {
  bottom: -10px;
  left: 1px;
  border-right-color: #ffffff;
  border-left-width: 0;
  content: " ";
}

.popover.bottom .arrow {
  top: -11px;
  left: 50%;
  margin-left: -11px;
  border-bottom-color: #999999;
  border-bottom-color: rgba(0, 0, 0, 0.25);
  border-top-width: 0;
}

.popover.bottom .arrow:after {
  top: 1px;
  margin-left: -10px;
  border-bottom-color: #ffffff;
  border-top-width: 0;
  content: " ";
}

.popover.left .arrow {
  top: 50%;
  right: -11px;
  margin-top: -11px;
  border-left-color: #999999;
  border-left-color: rgba(0, 0, 0, 0.25);
  border-right-width: 0;
}

.popover.left .arrow:after {
  right: 1px;
  bottom: -10px;
  border-left-color: #ffffff;
  border-right-width: 0;
  content: " ";
}

.carousel {
  position: relative;
}

.carousel-inner {
  position: relative;
  width: 100%;
  overflow: hidden;
}

.carousel-inner > .item {
  position: relative;
  display: none;
  -webkit-transition: 0.6s ease-in-out left;
          transition: 0.6s ease-in-out left;
}

.carousel-inner > .item > img,
.carousel-inner > .item > a > img {
  display: block;
  height: auto;
  max-width: 100%;
  line-height: 1;
}

.carousel-inner > .active,
.carousel-inner > .next,
.carousel-inner > .prev {
  display: block;
}

.carousel-inner > .active {
  left: 0;
}

.carousel-inner > .next,
.carousel-inner > .prev {
  position: absolute;
  top: 0;
  width: 100%;
}

.carousel-inner > .next {
  left: 100%;
}

.carousel-inner > .prev {
  left: -100%;
}

.carousel-inner > .next.left,
.carousel-inner > .prev.right {
  left: 0;
}

.carousel-inner > .active.left {
  left: -100%;
}

.carousel-inner > .active.right {
  left: 100%;
}

.carousel-control {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  width: 15%;
  font-size: 20px;
  color: #ffffff;
  text-align: center;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6);
  opacity: 0.5;
  filter: alpha(opacity=50);
}

.carousel-control.left {
  background-image: -webkit-gradient(linear, 0 top, 100% top, from(rgba(0, 0, 0, 0.5)), to(rgba(0, 0, 0, 0.0001)));
  background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.5) 0), color-stop(rgba(0, 0, 0, 0.0001) 100%));
  background-image: -moz-linear-gradient(left, rgba(0, 0, 0, 0.5) 0, rgba(0, 0, 0, 0.0001) 100%);
  background-image: linear-gradient(to right, rgba(0, 0, 0, 0.5) 0, rgba(0, 0, 0, 0.0001) 100%);
  background-repeat: repeat-x;
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#80000000', endColorstr='#00000000', GradientType=1);
}

.carousel-control.right {
  right: 0;
  left: auto;
  background-image: -webkit-gradient(linear, 0 top, 100% top, from(rgba(0, 0, 0, 0.0001)), to(rgba(0, 0, 0, 0.5)));
  background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.0001) 0), color-stop(rgba(0, 0, 0, 0.5) 100%));
  background-image: -moz-linear-gradient(left, rgba(0, 0, 0, 0.0001) 0, rgba(0, 0, 0, 0.5) 100%);
  background-image: linear-gradient(to right, rgba(0, 0, 0, 0.0001) 0, rgba(0, 0, 0, 0.5) 100%);
  background-repeat: repeat-x;
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#80000000', GradientType=1);
}

.carousel-control:hover,
.carousel-control:focus {
  color: #ffffff;
  text-decoration: none;
  opacity: 0.9;
  filter: alpha(opacity=90);
}

.carousel-control .icon-prev,
.carousel-control .icon-next,
.carousel-control .glyphicon-chevron-left,
.carousel-control .glyphicon-chevron-right {
  position: absolute;
  top: 50%;
  z-index: 5;
  display: inline-block;
}

.carousel-control .icon-prev,
.carousel-control .glyphicon-chevron-left {
  left: 50%;
}

.carousel-control .icon-next,
.carousel-control .glyphicon-chevron-right {
  right: 50%;
}

.carousel-control .icon-prev,
.carousel-control .icon-next {
  width: 20px;
  height: 20px;
  margin-top: -10px;
  margin-left: -10px;
  font-family: serif;
}

.carousel-control .icon-prev:before {
  content: '\2039';
}

.carousel-control .icon-next:before {
  content: '\203a';
}

.carousel-indicators {
  position: absolute;
  bottom: 10px;
  left: 50%;
  z-index: 15;
  width: 60%;
  padding-left: 0;
  margin-left: -30%;
  text-align: center;
  list-style: none;
}

.carousel-indicators li {
  display: inline-block;
  width: 10px;
  height: 10px;
  margin: 1px;
  text-indent: -999px;
  cursor: pointer;
  border: 1px solid #ffffff;
  border-radius: 10px;
}

.carousel-indicators .active {
  width: 12px;
  height: 12px;
  margin: 0;
  background-color: #ffffff;
}

.carousel-caption {
  position: absolute;
  right: 15%;
  bottom: 20px;
  left: 15%;
  z-index: 10;
  padding-top: 20px;
  padding-bottom: 20px;
  color: #ffffff;
  text-align: center;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6);
}

.carousel-caption .btn {
  text-shadow: none;
}

@media screen and (min-width: 768px) {
  .carousel-control .glyphicons-chevron-left,
  .carousel-control .glyphicons-chevron-right,
  .carousel-control .icon-prev,
  .carousel-control .icon-next {
    width: 30px;
    height: 30px;
    margin-top: -15px;
    margin-left: -15px;
    font-size: 30px;
  }
  .carousel-caption {
    right: 20%;
    left: 20%;
    padding-bottom: 30px;
  }
  .carousel-indicators {
    bottom: 20px;
  }
}

.clearfix:before,
.clearfix:after {
  display: table;
  content: " ";
}

.clearfix:after {
  clear: both;
}

.center-block {
  display: block;
  margin-right: auto;
  margin-left: auto;
}

.pull-right {
  float: right !important;
}

.pull-left {
  float: left !important;
}

.hide {
  display: none !important;
}

.show {
  display: block !important;
}

.invisible {
  visibility: hidden;
}

.text-hide {
  font: 0/0 a;
  color: transparent;
  text-shadow: none;
  background-color: transparent;
  border: 0;
}

.affix {
  position: fixed;
}

@-ms-viewport {
  width: device-width;
}

.hidden {
  display: none !important;
  visibility: hidden !important;
}

.visible-xs,
tr.visible-xs,
th.visible-xs,
td.visible-xs {
  display: none !important;
}

@media (max-width: 767px) {
  .visible-xs {
    display: block !important;
  }
  tr.visible-xs {
    display: table-row !important;
  }
  th.visible-xs,
  td.visible-xs {
    display: table-cell !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .visible-xs.visible-sm {
    display: block !important;
  }
  tr.visible-xs.visible-sm {
    display: table-row !important;
  }
  th.visible-xs.visible-sm,
  td.visible-xs.visible-sm {
    display: table-cell !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-xs.visible-md {
    display: block !important;
  }
  tr.visible-xs.visible-md {
    display: table-row !important;
  }
  th.visible-xs.visible-md,
  td.visible-xs.visible-md {
    display: table-cell !important;
  }
}

@media (min-width: 1200px) {
  .visible-xs.visible-lg {
    display: block !important;
  }
  tr.visible-xs.visible-lg {
    display: table-row !important;
  }
  th.visible-xs.visible-lg,
  td.visible-xs.visible-lg {
    display: table-cell !important;
  }
}

.visible-sm,
tr.visible-sm,
th.visible-sm,
td.visible-sm {
  display: none !important;
}

@media (max-width: 767px) {
  .visible-sm.visible-xs {
    display: block !important;
  }
  tr.visible-sm.visible-xs {
    display: table-row !important;
  }
  th.visible-sm.visible-xs,
  td.visible-sm.visible-xs {
    display: table-cell !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm {
    display: block !important;
  }
  tr.visible-sm {
    display: table-row !important;
  }
  th.visible-sm,
  td.visible-sm {
    display: table-cell !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-sm.visible-md {
    display: block !important;
  }
  tr.visible-sm.visible-md {
    display: table-row !important;
  }
  th.visible-sm.visible-md,
  td.visible-sm.visible-md {
    display: table-cell !important;
  }
}

@media (min-width: 1200px) {
  .visible-sm.visible-lg {
    display: block !important;
  }
  tr.visible-sm.visible-lg {
    display: table-row !important;
  }
  th.visible-sm.visible-lg,
  td.visible-sm.visible-lg {
    display: table-cell !important;
  }
}

.visible-md,
tr.visible-md,
th.visible-md,
td.visible-md {
  display: none !important;
}

@media (max-width: 767px) {
  .visible-md.visible-xs {
    display: block !important;
  }
  tr.visible-md.visible-xs {
    display: table-row !important;
  }
  th.visible-md.visible-xs,
  td.visible-md.visible-xs {
    display: table-cell !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .visible-md.visible-sm {
    display: block !important;
  }
  tr.visible-md.visible-sm {
    display: table-row !important;
  }
  th.visible-md.visible-sm,
  td.visible-md.visible-sm {
    display: table-cell !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md {
    display: block !important;
  }
  tr.visible-md {
    display: table-row !important;
  }
  th.visible-md,
  td.visible-md {
    display: table-cell !important;
  }
}

@media (min-width: 1200px) {
  .visible-md.visible-lg {
    display: block !important;
  }
  tr.visible-md.visible-lg {
    display: table-row !important;
  }
  th.visible-md.visible-lg,
  td.visible-md.visible-lg {
    display: table-cell !important;
  }
}

.visible-lg,
tr.visible-lg,
th.visible-lg,
td.visible-lg {
  display: none !important;
}

@media (max-width: 767px) {
  .visible-lg.visible-xs {
    display: block !important;
  }
  tr.visible-lg.visible-xs {
    display: table-row !important;
  }
  th.visible-lg.visible-xs,
  td.visible-lg.visible-xs {
    display: table-cell !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .visible-lg.visible-sm {
    display: block !important;
  }
  tr.visible-lg.visible-sm {
    display: table-row !important;
  }
  th.visible-lg.visible-sm,
  td.visible-lg.visible-sm {
    display: table-cell !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .visible-lg.visible-md {
    display: block !important;
  }
  tr.visible-lg.visible-md {
    display: table-row !important;
  }
  th.visible-lg.visible-md,
  td.visible-lg.visible-md {
    display: table-cell !important;
  }
}

@media (min-width: 1200px) {
  .visible-lg {
    display: block !important;
  }
  tr.visible-lg {
    display: table-row !important;
  }
  th.visible-lg,
  td.visible-lg {
    display: table-cell !important;
  }
}

.hidden-xs {
  display: block !important;
}

tr.hidden-xs {
  display: table-row !important;
}

th.hidden-xs,
td.hidden-xs {
  display: table-cell !important;
}

@media (max-width: 767px) {
  .hidden-xs,
  tr.hidden-xs,
  th.hidden-xs,
  td.hidden-xs {
    display: none !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .hidden-xs.hidden-sm,
  tr.hidden-xs.hidden-sm,
  th.hidden-xs.hidden-sm,
  td.hidden-xs.hidden-sm {
    display: none !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-xs.hidden-md,
  tr.hidden-xs.hidden-md,
  th.hidden-xs.hidden-md,
  td.hidden-xs.hidden-md {
    display: none !important;
  }
}

@media (min-width: 1200px) {
  .hidden-xs.hidden-lg,
  tr.hidden-xs.hidden-lg,
  th.hidden-xs.hidden-lg,
  td.hidden-xs.hidden-lg {
    display: none !important;
  }
}

.hidden-sm {
  display: block !important;
}

tr.hidden-sm {
  display: table-row !important;
}

th.hidden-sm,
td.hidden-sm {
  display: table-cell !important;
}

@media (max-width: 767px) {
  .hidden-sm.hidden-xs,
  tr.hidden-sm.hidden-xs,
  th.hidden-sm.hidden-xs,
  td.hidden-sm.hidden-xs {
    display: none !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .hidden-sm,
  tr.hidden-sm,
  th.hidden-sm,
  td.hidden-sm {
    display: none !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-sm.hidden-md,
  tr.hidden-sm.hidden-md,
  th.hidden-sm.hidden-md,
  td.hidden-sm.hidden-md {
    display: none !important;
  }
}

@media (min-width: 1200px) {
  .hidden-sm.hidden-lg,
  tr.hidden-sm.hidden-lg,
  th.hidden-sm.hidden-lg,
  td.hidden-sm.hidden-lg {
    display: none !important;
  }
}

.hidden-md {
  display: block !important;
}

tr.hidden-md {
  display: table-row !important;
}

th.hidden-md,
td.hidden-md {
  display: table-cell !important;
}

@media (max-width: 767px) {
  .hidden-md.hidden-xs,
  tr.hidden-md.hidden-xs,
  th.hidden-md.hidden-xs,
  td.hidden-md.hidden-xs {
    display: none !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .hidden-md.hidden-sm,
  tr.hidden-md.hidden-sm,
  th.hidden-md.hidden-sm,
  td.hidden-md.hidden-sm {
    display: none !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-md,
  tr.hidden-md,
  th.hidden-md,
  td.hidden-md {
    display: none !important;
  }
}

@media (min-width: 1200px) {
  .hidden-md.hidden-lg,
  tr.hidden-md.hidden-lg,
  th.hidden-md.hidden-lg,
  td.hidden-md.hidden-lg {
    display: none !important;
  }
}

.hidden-lg {
  display: block !important;
}

tr.hidden-lg {
  display: table-row !important;
}

th.hidden-lg,
td.hidden-lg {
  display: table-cell !important;
}

@media (max-width: 767px) {
  .hidden-lg.hidden-xs,
  tr.hidden-lg.hidden-xs,
  th.hidden-lg.hidden-xs,
  td.hidden-lg.hidden-xs {
    display: none !important;
  }
}

@media (min-width: 768px) and (max-width: 991px) {
  .hidden-lg.hidden-sm,
  tr.hidden-lg.hidden-sm,
  th.hidden-lg.hidden-sm,
  td.hidden-lg.hidden-sm {
    display: none !important;
  }
}

@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-lg.hidden-md,
  tr.hidden-lg.hidden-md,
  th.hidden-lg.hidden-md,
  td.hidden-lg.hidden-md {
    display: none !important;
  }
}

@media (min-width: 1200px) {
  .hidden-lg,
  tr.hidden-lg,
  th.hidden-lg,
  td.hidden-lg {
    display: none !important;
  }
}

.visible-print,
tr.visible-print,
th.visible-print,
td.visible-print {
  display: none !important;
}

@media print {
  .visible-print {
    display: block !important;
  }
  tr.visible-print {
    display: table-row !important;
  }
  th.visible-print,
  td.visible-print {
    display: table-cell !important;
  }
  .hidden-print,
  tr.hidden-print,
  th.hidden-print,
  td.hidden-print {
    display: none !important;
  }
}

/*
 * Bootstrap Documentation
 * Special styles for presenting Bootstrap's documentation and code examples.
 *
 * Table of contents:
 *
 * Scaffolding
 * Main navigation
 * Footer
 * Social buttons
 * Homepage
 * Page headers
 * Old docs callout
 * Side navigation
 * Docs sections
 * Callouts
 * Grid styles
 * Examples
 * Code snippets (highlight)
 * Responsive tests
 * Glyphicons
 * Customizer
 * Miscellaneous
 */

/*
 * Scaffolding
 *
 * Update the basics of our documents to prep for docs content.
 */

html {
  font-size: 100%;
}

body {
  position: relative;
  /* For scrollyspy */

  padding-top: 50px;
  /* Account for fixed navbar */

  font-size: 1em;
}

/* Keep code small in tables on account of limited space */

.table code {
  font-size: 13px;
  font-weight: normal;
}

/* Outline button for use within the docs */

.btn-outline {
  color: #563d7c;
  background-color: #fff;
  border-color: #e5e5e5;
}

.btn-outline:hover,
.btn-outline:focus,
.btn-outline:active {
  color: #fff;
  background-color: #3B2030;
  border-color: #563d7c;
}

/* Inverted outline button (white on dark) */

.btn-outline-inverse {
  color: #fff;
  background-color: transparent;
  border-color: #cdbfe3;
}

.btn-outline-inverse:hover,
.btn-outline-inverse:focus,
.btn-outline-inverse:active {
  color: #563d7c;
  text-shadow: none;
  background-color: #fff;
  border-color: #fff;
}

/*
 * Main navigation
 *
 * Turn the `.navbar` at the top of the docs purple.
 */

.bs-docs-nav {
  background-color: #732843;
  border-color: #463265;
  box-shadow: 0 1px 0 rgba(255, 255, 255, 0.1);
}

.bs-docs-nav .navbar-collapse {
  border-color: #463265;
}

.bs-docs-nav .navbar-brand {
  color: #fff;
}

.bs-docs-nav .navbar-nav > li > a {
  color: #E8EEF0	;
}

.bs-docs-nav .navbar-nav > li > a:hover {
  color: #fff;
}

.bs-docs-nav .navbar-nav > .active > a,
.bs-docs-nav .navbar-nav > .active > a:hover {
  color: #fff;
  background-color: #3B2030;
}

.bs-docs-nav .navbar-toggle {
  border-color: #563d7c;
}

.bs-docs-nav .navbar-toggle:hover {
  background-color: #463265;
  border-color: #463265;
}

/*
 * Footer
 *
 * Separated section of content at the bottom of all pages, save the homepage.
 */

.bs-footer {
  padding-top: 40px;
  padding-bottom: 30px;
  margin-top: 100px;
  color: #777;
  text-align: center;
  border-top: 1px solid #e5e5e5;
}

.footer-links li {
  display: inline;
  padding: 0 2px;
}

.footer-links li:first-child {
  padding-left: 0;
}

@media (min-width: 768px) {
  .bs-footer {
    text-align: left;
  }
  .bs-footer p {
    margin-bottom: 0;
  }
}

/*
 * Social buttons
 *
 * Twitter and GitHub social action buttons (for homepage and footer).
 */

.bs-social {
  margin-top: 20px;
  margin-bottom: 20px;
  text-align: center;
}

.bs-social-buttons {
  display: inline-block;
  padding-left: 0;
  margin-bottom: 0;
  list-style: none;
}

.bs-social-buttons li {
  display: inline-block;
  padding: 5px 8px;
  line-height: 1;
}

.bs-social-buttons .twitter-follow-button {
  width: 225px !important;
}

.bs-social-buttons .twitter-share-button {
  width: 98px !important;
}

/* Style the GitHub buttons via CSS instead of inline attributes */

.github-btn {
  overflow: hidden;
  border: 0;
}

@media screen and (min-width: 768px) {
  .bs-social {
    text-align: left;
  }
  .bs-social-buttons li:first-child {
    padding-left: 0;
  }
}

/*
 * Topography, yo!
 *
 * Apply the map background via base64 and relevant colors where we need 'em.
 */

.bs-docs-home,
.bs-header {
  color: #E8EEF0;
  background-color: #444444;
}

.bs-header a:link,
a:visisted,
a:hover {
  color: #fff;
}

/*
 * Homepage
 *
 * Tweaks to the custom homepage and the masthead (main jumbotron).
 */

/* Masthead (headings and download button) */

.bs-masthead {
  position: relative;
  padding: 30px 15px;
  text-align: center;
  text-shadow: 0 1px 0 rgba(0, 0, 0, 0.15);
}

.bs-masthead h1 {
  font-size: 50px;
  line-height: 1;
  color: #fff;
}

.icon {
  padding-bottom: 20px;
  font-size: 900%;
  color: rgba(153, 153, 153, 0.5);
}

.bs-masthead .btn-outline {
  padding: 18px 24px;
  margin-top: 20px;
  margin-bottom: 20px;
  font-size: 21px;
}

.bs-masthead li {
  max-width: 700px;
  padding: 1em 0 1em 0;
  color: #fff;
}

.bs-masthead a {
  color: #fff;
  text-decoration: underline;
  background-color: #444;
}

/* Links to project-level content like the repo, Expo, etc */

.bs-masthead-links {
  padding: 0 15px;
  margin-top: 20px;
  margin-bottom: 20px;
  text-align: center;
  list-style: none;
}

.bs-masthead-links li {
  display: inline;
  color: white;
}

.bs-masthead-links li + li {
  margin-left: 20px;
}

@media screen and (min-width: 768px) {
  .bs-masthead {
    padding-top: 50px;
    padding-bottom: 140px;
    text-align: left;
  }
  .bs-masthead h1 {
    padding-bottom: 40px;
    font-size: 100px;
  }
  .bs-masthead h3 {
    color: #f0f7fd;
  }
  .bs-masthead .lead {
    margin-right: 25%;
    font-size: 30px;
  }
  .bs-masthead-links {
    padding: 0;
    text-align: left;
  }
}

/*
 * Page headers
 *
 * Jumbotron-esque headers at the top of every page that's not the homepage.
 */

/* Page headers */

.bs-header {
  padding: 30px 15px 40px;
  /* side padding builds on .container 15px, so 30px */

  font-size: 16px;
  text-align: center;
  text-shadow: 0 1px 0 rgba(0, 0, 0, 0.15);
}

.bs-header h1 {
  color: #fff;
}

.bs-header p {
  line-height: 1.5;
}

.bs-header .container {
  position: relative;
}

@media screen and (min-width: 768px) {
  .bs-header {
    font-size: 21px;
    text-align: left;
  }
  .bs-header h1 {
    font-size: 60px;
    line-height: 1;
  }
}

@media screen and (min-width: 992px) {
  .bs-header h1,
  .bs-header p {
    margin-right: 380px;
  }
}

/*
 * Callout for 2.3.2 docs
 *
 * Only appears below page headers (not on the homepage). The homepage gets its
 * own link with the masthead links.
 */

.bs-old-docs {
  padding: 15px 20px;
  color: #777;
  background-color: #fafafa;
  border-top: 1px solid #fff;
  border-bottom: 1px solid #e5e5e5;
}

.bs-old-docs strong {
  color: #555;
}

/*
 * Side navigation
 *
 * Scrollspy and affixed enhanced navigation to highlight sections and secondary
 * sections of docs content.
 */

/* By default it's not affixed in mobile views, so undo that */

.bs-sidebar.affix {
  position: static;
}

/* First level of nav */

.bs-sidenav {
  padding-top: 10px;
  padding-bottom: 10px;
  margin-top: 30px;
  margin-bottom: 30px;
  text-shadow: 0 1px 0 #fff;
  background-color: #f7f5fa;
  border-radius: 5px;
}

/* All levels of nav */

.bs-sidebar .nav > li > a {
  display: block;
  padding: 5px 20px;
  color: #716b7a;
}

.bs-sidebar .nav > li > a:hover,
.bs-sidebar .nav > li > a:focus {
  text-decoration: none;
  background-color: #e5e3e9;
  border-right: 1px solid #dbd8e0;
}

.bs-sidebar .nav > .active > a,
.bs-sidebar .nav > .active:hover > a,
.bs-sidebar .nav > .active:focus > a {
  font-weight: bold;
  color: #563d7c;
  background-color: transparent;
  border-right: 1px solid #563d7c;
}

/* Nav: second level (shown on .active) */

.bs-sidebar .nav .nav {
  display: none;
  /* Hide by default, but at >768px, show it */

  margin-bottom: 8px;
}

.bs-sidebar .nav .nav > li > a {
  padding-top: 3px;
  padding-bottom: 3px;
  padding-left: 30px;
  font-size: 90%;
}

/* Show and affix the side nav when space allows it */

@media screen and (min-width: 992px) {
  {
    /* Widen the fixed sidebar */
  
  }
  .bs-sidebar .nav > .active > ul {
    display: block;
  }
  .bs-sidebar.affix,
  .bs-sidebar.affix-bottom {
    width: 213px;
  }
  .bs-sidebar.affix {
    position: fixed;
    /* Undo the static from mobile first approach */
  
    top: 80px;
  }
  .bs-sidebar.affix-bottom {
    position: absolute;
    /* Undo the static from mobile first approach */
  
  }
  .bs-sidebar.affix-bottom .bs-sidenav,
  .bs-sidebar.affix .bs-sidenav {
    margin-top: 0;
    margin-bottom: 0;
  }
}

@media screen and (min-width: 1200px) {
  {
    /* Widen the fixed sidebar again */
  
  }
  .bs-sidebar.affix-bottom,
  .bs-sidebar.affix {
    width: 263px;
  }
}

/*
 * Docs sections
 *
 * Content blocks for each component or feature.
 */

/* Space things out */

.bs-docs-section + .bs-docs-section {
  padding-top: 40px;
}

/* Janky fix for preventing navbar from overlapping */

h1[id] {
  padding-top: 80px;
  margin-top: -45px;
}

/*
 * Callouts
 *
 * Not quite alerts, but custom and helpful notes for folks reading the docs.
 * Requires a base and modifier class.
 */

/* Common styles for all types */

.bs-callout {
  padding: 15px 30px 15px 15px;
  margin: 20px 0;
  border-left: 5px solid #eee;
}

.bs-callout h4 {
  margin-top: 0;
}

.bs-callout p:last-child {
  margin-bottom: 0;
}

.bs-callout code,
.bs-callout .highlight {
  background-color: #fff;
}

/* Variations */

.bs-callout-danger {
  background-color: #fcf2f2;
  border-color: #dFb5b4;
}

.bs-callout-warning {
  background-color: #fefbed;
  border-color: #f1e7bc;
}

.bs-callout-info {
  background-color: #f0f7fd;
  border-color: #d0e3f0;
}

/*
 * Grid examples
 *
 * Highlight the grid columns within the docs so folks can see their padding,
 * alignment, sizing, etc.
 */

.show-grid {
  margin-bottom: 15px;
}

.show-grid [class^="col-"] {
  padding-top: 10px;
  padding-bottom: 10px;
  background-color: #eee;
  background-color: rgba(86, 61, 124, 0.15);
  border: 1px solid #ddd;
  border: 1px solid rgba(86, 61, 124, 0.2);
}

/*
 * Examples
 *
 * Isolated sections of example content for each component or feature. Usually
 * followed by a code snippet.
 */

.bs-example {
  position: relative;
  padding: 45px 15px 15px;
  margin: 0 -15px 15px;
  background-color: #fafafa;
  border-color: #e5e5e5 #eee #eee;
  border-style: solid;
  border-width: 1px 0;
  box-shadow: inset 0 3px 6px rgba(0, 0, 0, 0.05);
}

/* Echo out a label for the example */

.bs-example:after {
  position: absolute;
  top: 15px;
  left: 15px;
  font-size: 12px;
  font-weight: bold;
  letter-spacing: 1px;
  color: #bbb;
  text-transform: uppercase;
  content: "Example";
}

/* Tweak display of the code snippets when following an example */

.bs-example + .highlight {
  margin: -15px -15px 15px;
  border-width: 0 0 1px;
  border-radius: 0;
}

/* Make the examples and snippets not full-width */

@media screen and (min-width: 768px) {
  .bs-example {
    margin-right: 0;
    margin-left: 0;
    background-color: #fff;
    border-color: #ddd;
    border-width: 1px;
    border-radius: 4px 4px 0 0;
    box-shadow: none;
  }
  .bs-example + .highlight {
    margin-top: -16px;
    margin-right: 0;
    margin-left: 0;
    border-width: 1px;
    border-bottom-right-radius: 4px;
    border-bottom-left-radius: 4px;
  }
}

/* Tweak content of examples for optimum awesome */

.bs-example > p:last-child,
.bs-example > ul:last-child,
.bs-example > ol:last-child,
.bs-example > blockquote:last-child,
.bs-example > .form-control:last-child,
.bs-example > .table:last-child,
.bs-example > .navbar:last-child,
.bs-example > .jumbotron:last-child,
.bs-example > .alert:last-child,
.bs-example > .panel:last-child,
.bs-example > .list-group:last-child,
.bs-example > .well:last-child,
.bs-example > .progress:last-child,
.bs-example > .table-responsive:last-child > .table {
  margin-bottom: 0;
}

.bs-example > p > .close {
  float: none;
}

/* Typography */

.bs-example-type .table .info {
  color: #999;
  vertical-align: middle;
}

.bs-example-type .table td {
  padding: 15px 0;
  border-color: #eee;
}

.bs-example-type .table tr:first-child td {
  border-top: 0;
}

.bs-example-type h1,
.bs-example-type h2,
.bs-example-type h3,
.bs-example-type h4,
.bs-example-type h5,
.bs-example-type h6 {
  margin: 0;
}

/* Images */

.bs-example > .img-circle,
.bs-example > .img-rounded,
.bs-example > .img-thumbnail {
  margin: 5px;
}

/* Buttons */

.bs-example > .btn,
.bs-example > .btn-group {
  margin-top: 5px;
  margin-bottom: 5px;
}

.bs-example > .btn-toolbar + .btn-toolbar {
  margin-top: 10px;
}

/* Forms */

.bs-example-control-sizing select,
.bs-example-control-sizing input[type="text"] + input[type="text"] {
  margin-top: 10px;
}

.bs-example-form .input-group {
  margin-bottom: 10px;
}

.bs-example > textarea.form-control {
  resize: vertical;
}

/* List groups */

.bs-example > .list-group {
  max-width: 400px;
}

/* Navbars */

.bs-example .navbar:last-child {
  margin-bottom: 0;
}

.bs-navbar-top-example,
.bs-navbar-bottom-example {
  z-index: 1;
  padding: 0;
  overflow: hidden;
  /* cut the drop shadows off */

}

.bs-navbar-top-example .navbar-header,
.bs-navbar-bottom-example .navbar-header {
  margin-left: 0;
}

.bs-navbar-top-example .navbar-fixed-top,
.bs-navbar-bottom-example .navbar-fixed-bottom {
  position: relative;
  margin-right: 0;
  margin-left: 0;
}

.bs-navbar-top-example {
  padding-bottom: 45px;
}

.bs-navbar-top-example:after {
  top: auto;
  bottom: 15px;
}

.bs-navbar-top-example .navbar-fixed-top {
  top: -1px;
}

.bs-navbar-bottom-example {
  padding-top: 45px;
}

.bs-navbar-bottom-example .navbar-fixed-bottom {
  bottom: -1px;
}

.bs-navbar-bottom-example .navbar {
  margin-bottom: 0;
}

@media (min-width: 768px) {
  .bs-navbar-top-example .navbar-fixed-top,
  .bs-navbar-bottom-example .navbar-fixed-bottom {
    position: absolute;
  }
  .bs-navbar-top-example {
    border-radius: 0 0 4px 4px;
  }
  .bs-navbar-bottom-example {
    border-radius: 4px 4px 0 0;
  }
}

/* Pagination */

.bs-example .pagination {
  margin-top: 10px;
  margin-bottom: 10px;
}

/* Pager */

.bs-example > .pager {
  margin-top: 0;
}

/* Example modals */

.bs-example-modal {
  background-color: #f5f5f5;
}

.bs-example-modal .modal {
  position: relative;
  top: auto;
  right: auto;
  bottom: auto;
  left: auto;
  z-index: 1;
  display: block;
}

.bs-example-modal .modal-dialog {
  left: auto;
  margin-right: auto;
  margin-left: auto;
}

/* Example dropdowns */

.bs-example > .dropdown > .dropdown-menu {
  position: static;
  display: block;
  margin-bottom: 5px;
}

/* Example tabbable tabs */

.bs-example-tabs .nav-tabs {
  margin-bottom: 15px;
}

/* Tooltips */

.bs-example-tooltips {
  text-align: center;
}

.bs-example-tooltips > .btn {
  margin-top: 5px;
  margin-bottom: 5px;
}

/* Popovers */

.bs-example-popover {
  padding-bottom: 24px;
  background-color: #f9f9f9;
}

.bs-example-popover .popover {
  position: relative;
  display: block;
  float: left;
  width: 260px;
  margin: 20px;
}

/* Scrollspy demo on fixed height div */

.scrollspy-example {
  position: relative;
  height: 200px;
  margin-top: 10px;
  overflow: auto;
}

/*
 * Code snippets
 *
 * Generated via Pygments and Jekyll, these are snippets of HTML, CSS, and JS.
 */

.highlight {
  display: none;
  /* hidden by default, until >480px */

  padding: 9px 14px;
  margin-bottom: 14px;
  background-color: #f7f7f9;
  border: 1px solid #e1e1e8;
  border-radius: 4px;
}

.highlight pre {
  padding: 0;
  margin-top: 0;
  margin-bottom: 0;
  white-space: nowrap;
  background-color: transparent;
  border: 0;
}

.highlight pre code {
  font-size: inherit;
  color: #333;
  /* Effectively the base text color */

}

.highlight pre .lineno {
  display: inline-block;
  width: 22px;
  padding-right: 5px;
  margin-right: 10px;
  color: #bebec5;
  text-align: right;
}

/* Show code snippets when we have the space */

@media screen and (min-width: 481px) {
  .highlight {
    display: block;
  }
}

/*
 * Responsive tests
 *
 * Generate a set of tests to show the responsive utilities in action.
 */

/* Responsive (scrollable) doc tables */

.table-responsive .highlight pre {
  white-space: normal;
}

/* Utility classes table  */

.bs-table th small,
.responsive-utilities th small {
  display: block;
  font-weight: normal;
  color: #999;
}

.responsive-utilities tbody th {
  font-weight: normal;
}

.responsive-utilities td {
  text-align: center;
}

.responsive-utilities td.is-visible {
  color: #468847;
  background-color: #dff0d8 !important;
}

.responsive-utilities td.is-hidden {
  color: #ccc;
  background-color: #f9f9f9 !important;
}

/* Responsive tests */

.responsive-utilities-test {
  margin-top: 5px;
}

.responsive-utilities-test .col-xs-6 {
  margin-bottom: 10px;
}

.responsive-utilities-test span {
  padding: 15px 10px;
  font-size: 14px;
  font-weight: bold;
  line-height: 1.1;
  text-align: center;
  border-radius: 4px;
}

.visible-on .col-xs-6 .hidden-xs,
.visible-on .col-xs-6 .hidden-sm,
.visible-on .col-xs-6 .hidden-md,
.visible-on .col-xs-6 .hidden-lg,
.hidden-on .col-xs-6 .visible-xs,
.hidden-on .col-xs-6 .visible-sm,
.hidden-on .col-xs-6 .visible-md,
.hidden-on .col-xs-6 .visible-lg {
  color: #999;
  border: 1px solid #ddd;
}

.visible-on .col-xs-6 .visible-xs,
.visible-on .col-xs-6 .visible-sm,
.visible-on .col-xs-6 .visible-md,
.visible-on .col-xs-6 .visible-lg,
.hidden-on .col-xs-6 .hidden-xs,
.hidden-on .col-xs-6 .hidden-sm,
.hidden-on .col-xs-6 .hidden-md,
.hidden-on .col-xs-6 .hidden-lg {
  color: #468847;
  background-color: #dff0d8;
  border: 1px solid #d6e9c6;
}

/*
 * Glyphicons
 *
 * Special styles for displaying the icons and their classes in the docs.
 */

.bs-glyphicons {
  padding-bottom: 1px;
  padding-left: 0;
  margin-bottom: 20px;
  overflow: hidden;
  list-style: none;
}

.bs-glyphicons li {
  float: left;
  width: 25%;
  height: 115px;
  padding: 10px;
  margin: 0 -1px -1px 0;
  font-size: 12px;
  line-height: 1.4;
  text-align: center;
  border: 1px solid #ddd;
}

.bs-glyphicons .glyphicon {
  display: block;
  margin: 5px auto 10px;
  font-size: 24px;
}

.bs-glyphicons li:hover {
  background-color: rgba(86, 61, 124, 0.1);
}

@media (min-width: 768px) {
  .bs-glyphicons li {
    width: 12.5%;
  }
}

/*
 * Customizer
 *
 * Since this is so form control heavy, we have quite a few styles to customize
 * the display of inputs, headings, and more. Also included are all the download
 * buttons and actions.
 */

.bs-customizer .toggle {
  float: right;
  margin-top: 85px;
  /* On account of ghetto navbar fix */

}

/* Headings and form contrls */

.bs-customizer label {
  margin-top: 10px;
  font-weight: 500;
  color: #444;
}

.bs-customizer h2 {
  padding-top: 30px;
  margin-top: 0;
  margin-bottom: 5px;
}

.bs-customizer h4 {
  margin-top: 15px;
}

.bs-customizer input[type="text"] {
  font-family: Menlo, Monaco, Consolas, "Courier New", monospace;
  background-color: #fafafa;
}

.bs-customizer .help-block {
  font-size: 12px;
}

/* For the variables, use regular weight */

#less-section label {
  font-weight: normal;
}

/* Downloads */

.bs-customize-download .btn-outline {
  padding: 20px;
}

/* Error handling */

.bs-customizer-alert {
  position: fixed;
  top: 51px;
  right: 0;
  left: 0;
  z-index: 1030;
  padding: 15px 0;
  color: #fff;
  background-color: #d9534f;
  border-bottom: 1px solid #b94441;
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.25);
}

.bs-customizer-alert .close {
  margin-top: -4px;
  font-size: 24px;
}

.bs-customizer-alert p {
  margin-bottom: 0;
}

.bs-customizer-alert .glyphicon {
  margin-right: 5px;
}

.bs-customizer-alert pre {
  margin: 10px 0 0;
  color: #fff;
  background-color: #a83c3a;
  border-color: #973634;
  box-shadow: inset 0 2px 4px rgba(0, 0, 0, 0.05), 0 1px 0 rgba(255, 255, 255, 0.1);
}

/*
 * Miscellaneous
 *
 * Odds and ends for optimum docs display.
 */

/* Examples gallery: space out content better */

.bs-examples h4 {
  margin-bottom: 5px;
}

.bs-examples p {
  margin-bottom: 20px;
}

/* Pseudo :focus state for showing how it looks in the docs */

#focusedInput {
  border-color: rgba(82, 168, 236, 0.8);
  outline: 0;
  outline: thin dotted \9;
  /* IE6-9 */

  -moz-box-shadow: 0 0 8px rgba(82, 168, 236, 0.6);
       box-shadow: 0 0 8px rgba(82, 168, 236, 0.6);
}

/* Better spacing on download options in getting started */

.bs-docs-dl-options h4 {
  margin-top: 15px;
  margin-bottom: 5px;
}

li {
  max-width: 700px;
}

/* LESS Document */

/* typography  */

h1 {
  color: #222222;
}

h2,
h3 {
  color: #3b2030;
}

h4,
h5 {
  color: #732843;
}

/*  For Icon Fonts  */

.visuallyhidden {
  position: absolute;
  width: 1px;
  height: 1px;
  padding: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0 0 0 0);
  border: 0;
}

.reflect {
  color: #006b33;
}

.focus {
  color: #175473;
}

.learn {
  color: #6c2a92;
}

.advance {
  color: #bd4800;
}

.bs-sidenav {
  font-size: 14px;
  line-height: 1em;
}

.modal-backdrop.fade {
  opacity: 0;
  filter: alpha(opacity=0);
}

.modal-backdrop.in {
  opacity: 0.7;
  filter: alpha(opacity=70);
}

.breadcrumb > li + li:before {
  padding: 0 5px;
  font-family: 'TS';
  color: #cccccc;
  content: "\f0da";
}

/*  Focus  classess 

== Tane
== Oct 25 2013

*/

.container-fluid {
  min-width: 100%;
  padding: 0 20px;
}

.content-fluid {
  min-width: 100%;
  padding: 0 40px;
}

.admin-wrap {
  padding-bottom: 40px;
  background: #f4f4f4;
}

/* Styles.less */

/*  Teachscape Burgundy */

/*  ============  major page layout items  ============  */

body {
  padding-top: 0;
}

.disabled {
  color: #999999;
}

.fluid {
  width: 100%;
}

.divider {
  display: inline;
  height: 10px;
  margin: 0 10px;
  border-right: 1px solid #737373;
}

.disp-inline {
  display: inline-block;
}

.primary {
  color: #2f4fa2;
}

.red {
  color: #732843;
}

/*  ============   navigation items  ============   */

.ts-subnav {
  padding: 0 0px;
  background: #fff;
  border-top: 1px dotted #444444;
  border-bottom: 1px dotted #444444;
}

.ts-navbar {
  width: 100%;
  padding-bottom: 70px;
  background: #fff;
}

.nav-main {
  margin-bottom: 10px;
}

.admin-subnav {
  background: #fff;
}

.admin-subnav ul li.active {
  border-top: none;
}

.nav li.active {
  padding-top: 6px;
  color: #444;
  border-top: 4px solid #175473;
}

.nav li {
  display: inline-block;
  padding: 0 20px;
  color: #2f4fa2;
  list-style: none;
}

.nav li a {
  color: #2f4fa2;
  background: none;
}

.nav li a:hover {
  color: #fff;
  background: #2f4fa2;
}

.top-row {
  margin-top: 70px;
  margin-bottom: 50px;
}

.top-row div h1 {
  margin-top: 0;
  margin-bottom: 0;
}

.btn-spaced {
  display: inline-block;
  padding: 6px 12px;
}

.btn-icon-active {
  display: inline-block;
  padding: 6px 12px;
  color: #2f4fa2;
}

.btn-icon-active:hover {
  color: #1e3267;
}

/*  ============   content areas and panels  ============   */

.panel {
  padding: 50px;
  box-shadow: 0px 1px 5px #eeeeee;
}

.content-area {
  margin: 30px 0;
}

.squared {
  border-radius: 0;
}

.title-panel {
  margin: 0 0px 30px 0px;
}

/*  ============   tables ============   */

.tall-table tbody tr td {
  padding-top: 10px;
  padding-bottom: 10px;
}

.wide-table {
  width: 100%;
}

/*  ============   icon helpers  ============   */

.info-title h4 {
  text-align: center;
}

/*  ============   forms   ============  */

.label-dark {
  background: #333333;
}

.input-invisible {
  margin-right: 20px;
  background: none;
  border: 0;
}

.input-invisible:hover {
  background: #fff;
  border: 1px;
}

/* ============    accordion  ============   */

.accord-panel {
  margin-bottom: 50px;
}

.panel-heading.borderless {
  border: 0;
}

/* ============   call to action row */

.action-wrap {
  padding: 30px, 0, 20px, 30px;
  text-align: right;
}

.call-bar-top {
  padding: 20px 0 30px 0;
  background: url(../../images/shadow-down.png) repeat-x bottom left;
  border-top: 1px dotted #444;
}

.call-bar-center {
  text-align: center;
}

.call-bar-right {
  text-align: right;
}

/* ============  jquery ui overrides   ============  */

.ui-state-default,
.ui-widget-content .ui-state-default,
.ui-widget-header .ui-state-default {
  height: 40px;
  color: #555555;
  background: #555555;
  border: 1px solid #d3d3d3;
  -webkit-border-radius: 5px;
     -moz-border-radius: 5px;
          border-radius: 5px;
}

.sortable-list {
  padding: 0;
  margin: 0 0 10px 0;
  list-style-type: none;
}

.sortable-list li {
  padding: 8px;
  padding-left: 1.5em;
}

.sortable-list li span {
  position: absolute;
  margin-left: -1.3em;
}

/* ============  bar states   ============  */

.bar-section {
  display: block;
  float: right;
  margin-bottom: 10px;
  background-image: linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -o-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -moz-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -webkit-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -ms-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
}

.bar-section-scoring {
  display: block;
  float: right;
  height: auto;
  margin-bottom: 10px;
  background-image: linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -o-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -moz-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -webkit-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -ms-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
}

.bar-scoring-levels {
  display: block;
  float: left;
  padding: 5px;
  margin: 10px 5px;
  background-image: linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -o-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -moz-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -webkit-linear-gradient(top, #ffffff 11%, #c6d5e6 100%);
  background-image: -ms-lineargradient(top, #ffffff 11%, #c6d5e6 100%);
  border: 1px solid #999999;
  border-radius: 5px;
}

#suggested-ui {
  list-style-type: none;
}

.bar-suggested {
  display: block;
  float: right;
  height: auto;
  max-width: inherit;
  padding: 5px;
  margin-bottom: 10px;
  text-align: right;
  list-style: none;
  background: none;
  border: 1px dashed #444444;
}

.bar-1 {
  width: 100%;
  max-width: 100%;
  margin-top: 20px;
}

.bar-2 {
  width: 90%;
  max-width: 90%;
}

.bar-3 {
  width: 80%;
  max-width: 80%;
}

.bar-4 {
  width: 70%;
  max-width: 70%;
}

.bar-5 {
  width: 60%;
  max-width: 60%;
}

.bar-actions {
  float: right;
  margin-top: -3px;
}

.label-score {
  display: inline-block;
  width: 40%;
}

/* ============  bootstrap overrides   ============  */

.breadcrumb {
  padding: 0;
  background: none;
}
