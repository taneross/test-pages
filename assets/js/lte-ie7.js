/* Load this script using conditional IE comments if you need to support IE 7 and IE 6. */

window.onload = function() {
	function addIcon(el, entity) {
		var html = el.innerHTML;
		el.innerHTML = '<span style="font-family: \'TS\'">' + entity + '</span>' + html;
	}
	var icons = {
			'icon-microphone' : '&#xf130;',
			'icon-microphone-off' : '&#xf131;',
			'icon-Focus-Logo' : '&#xe002;',
			'icon-Reflect-Logo' : '&#xe003;',
			'icon-Learn-Logo' : '&#xe004;',
			'icon-Advance-Logo' : '&#xe005;',
			'icon-Classroom' : '&#xe007;',
			'icon-Teachscape' : '&#xe001;',
			'icon-Advance' : '&#xe044;',
			'icon-Focus' : '&#xe045;',
			'icon-Learn' : '&#xe046;',
			'icon-Reflect' : '&#xe047;',
			'icon-play-sign' : '&#xf144;',
			'icon-cut' : '&#xf0c4;',
			'icon-comment' : '&#xf075;',
			'icon-comments' : '&#xf086;',
			'icon-th' : '&#xf00a;',
			'icon-th-list' : '&#xf00b;',
			'icon-reorder' : '&#xf0c9;',
			'icon-star' : '&#xf005;',
			'icon-star-empty' : '&#xf006;',
			'icon-ok' : '&#xf00c;',
			'icon-remove' : '&#xf00d;',
			'icon-trash' : '&#xf014;',
			'icon-home' : '&#xe008;',
			'icon-Walkthrough' : '&#xe006;',
			'icon-lock' : '&#xf024;',
			'icon-pencil' : '&#xf040;',
			'icon-check-empty' : '&#xf096;',
			'icon-facebook-sign' : '&#xf082;',
			'icon-linkedin-sign' : '&#xf08c;',
			'icon-twitter' : '&#xf099;',
			'icon-calendar' : '&#xf073;',
			'icon-warning' : '&#xe009;',
			'icon-minus-sign-alt' : '&#xf146;',
			'icon-plus-sign' : '&#xf0fe;',
			'icon-facetime-video' : '&#xf03d;',
			'icon-spell-check' : '&#xe00a;',
			'icon-download' : '&#xe000;',
			'icon-list-alt' : '&#xf022;',
			'icon-file' : '&#xf016;',
			'icon-paste' : '&#xf0ea;',
			'icon-caret-down' : '&#xf0d7;',
			'icon-caret-up' : '&#xf0d8;',
			'icon-caret-left' : '&#xf0d9;',
			'icon-info' : '&#xf129;',
			'icon-picture' : '&#xf03e;',
			'icon-headphones' : '&#xf025;',
			'icon-circle-blank' : '&#xf10c;',
			'icon-circle' : '&#xf111;',
			'icon-sort-by-alphabet' : '&#xf15d;',
			'icon-sort-by-alphabet-alt' : '&#xf15e;',
			'icon-sort-by-order' : '&#xf162;',
			'icon-sort-by-order-alt' : '&#xf163;',
			'icon-certificate' : '&#xf0a3;',
			'icon-table' : '&#xf0ce;',
			'icon-folder-close' : '&#xf07b;',
			'icon-film' : '&#xe00b;',
			'icon-refresh' : '&#xf021;',
			'icon-question-sign' : '&#xf059;',
			'icon-chevron-left' : '&#xf053;',
			'icon-chevron-right' : '&#xf054;',
			'icon-chevron-up' : '&#xf077;',
			'icon-chevron-down' : '&#xf078;',
			'icon-dashboard' : '&#xf0e4;',
			'icon-plus' : '&#xf067;',
			'icon-minus' : '&#xf068;',
			'icon-asterisk' : '&#xf069;',
			'icon-Teachscape-2' : '&#xe016;',
			'icon-down' : '&#xf2fe;',
			'icon-downleft' : '&#xf2ff;',
			'icon-downright' : '&#xf300;',
			'icon-up' : '&#xf301;',
			'icon-upleft' : '&#xf302;',
			'icon-upright' : '&#xf303;',
			'icon-right' : '&#xf304;',
			'icon-left' : '&#xf305;',
			'icon-file-pdf' : '&#xe00c;',
			'icon-caret-right' : '&#xf0da;',
			'icon-check' : '&#xf046;',
			'icon-check-2' : '&#xe00d;',
			'icon-new-tab' : '&#xe00e;'
		},
		els = document.getElementsByTagName('*'),
		i, attr, c, el;
	for (i = 0; ; i += 1) {
		el = els[i];
		if(!el) {
			break;
		}
		attr = el.getAttribute('data-icon');
		if (attr) {
			addIcon(el, attr);
		}
		c = el.className;
		c = c.match(/icon-[^\s'"]+/);
		if (c && icons[c[0]]) {
			addIcon(el, icons[c[0]]);
		}
	}
};