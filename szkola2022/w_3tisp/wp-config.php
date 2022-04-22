<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'w_3tisp' );

/** Database username */
define( 'DB_USER', 'w_3tisp' );

/** Database password */
define( 'DB_PASSWORD', 'w_3tisp' );

/** Database hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'we>Q;K=rSP)Of3?NE3w0v#x.V-4)h(t2Z<K~thAgGuOH7t%8Vs.pRIla}{Y/pOf%' );
define( 'SECURE_AUTH_KEY',  'on}UaNzbT}kt7<xZ% {$KcM9+wa!NAkXwTbd{y7/pS<Ue~m;JSe5K[U6ft_xBC]v' );
define( 'LOGGED_IN_KEY',    '0~z%}/gp A/mzy1@Zwti)5#9xUgt3O]e ;-Sl(.IvumS;*Fn-c|EwH8(G)Vde{U ' );
define( 'NONCE_KEY',        '7F5ub=4xU0`js@a$5UGJP_MwGg~w:Uj*,XyDSq3pX s&lXAUbTHD14WO.l$D5%1,' );
define( 'AUTH_SALT',        'GVunVez^6`pevG4>Vs/Xvhsy@>Q!eD=vCkazFFE/R= P7|c(+H8Pq3~oyy#A..%=' );
define( 'SECURE_AUTH_SALT', 'VQDrY+RGpGQ@7LYGWG(|R#G.{a2crnO_.>FspDas/Hl3nC0~fxiGfeVp.cx=#$F>' );
define( 'LOGGED_IN_SALT',   'd#ICyAB;)iWoJ<]7;M~Gs?Cas`Y6&Q~4edu_iet*&+?7SnIP[>RZ5ld>Dm~^3*~:' );
define( 'NONCE_SALT',       '?ZGMHA}=a:}|_MZ!e3;3a@9_i CLq1-V^H f_>N5mp^uwZn,f6HL%5cicHLU$.(h' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
