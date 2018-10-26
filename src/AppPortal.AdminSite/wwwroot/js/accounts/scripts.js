'use strict';
const ACCOUNT_API = {
    // For All user
    SIGN_OUT: 'api/account/sign-out',
    CHANGE_PASSWORD: 'api/account/change-password',
    SETUP_PASSWORD: 'api/account/setup-password',
    // Ony Administrator
    RESET_PASSWORD: 'api/account/reset-password',
    CHANGE_EMAIL: 'api/account/change-email',
    CONFIRM_EMAIL: 'api/account/confirm-email',
    // AllowAnonymous
    CONNECT_TOKEN: 'api/account/token',
    FORGOT_PASSWORD: 'api/account/forgot-password',
    RESET_PASSWORD_FORGET: 'api/account/reset-password-forget',
};