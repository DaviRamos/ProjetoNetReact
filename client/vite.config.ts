import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'
import tailwindcss from '@tailwindcss/vite'

// https://vite.dev/config/
export default defineConfig({
  plugins: [react(), tailwindcss()],
  server: {
    port: 5175, // Change 3000 to your desired port number
    strictPort: true // Optional: Exit if the port is already in use, instead of trying the next available port
  },
});


