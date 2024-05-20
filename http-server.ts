import { serveDir } from 'https://deno.land/std@0.224.0/http/file_server.ts';
import { serve } from 'https://deno.land/std@0.224.0/http/server.ts';

serve((req: Request) => {
    const pathname = new URL(req.url).pathname;

    if (pathname.endsWith('.wasm.br')) {
        return serveDir(req, {
            fsRoot: 'dist/webgl',
            urlRoot: 'webgl',
            headers: [
                'Content-Encoding: br',
                'Content-Type: application/wasm',
            ],
        });
    }

    if (pathname.endsWith('.br')) {
        return serveDir(req, {
            fsRoot: 'dist/webgl',
            urlRoot: 'webgl',
            headers: [
                'Content-Encoding: br',
            ],
        });
    }

    if (pathname.endsWith('.wasm')) {
        return serveDir(req, {
            fsRoot: 'dist/webgl',
            urlRoot: 'webgl',
            headers: [
                'Content-Type: application/wasm',
            ],
        });
    }

    if (pathname.startsWith('/webgl')) {
        return serveDir(req, {
            fsRoot: 'dist/webgl',
            urlRoot: 'webgl',
        });
    }

    return new Response('404: Not Found', {
        status: 404,
    });
}, {
    port: 5000,
});